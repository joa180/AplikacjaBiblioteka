using LibSys.Data;
using LibSys.Models.Entities;   // tu jest klasa Reader
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;

namespace LibSys.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _db;               // <<< injectujemy DbContext

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext db                    // <<< tu
        )
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = (IUserEmailStore<IdentityUser>)userStore;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _db = db;                         // <<< przypisujemy
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required, EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required, StringLength(100, MinimumLength = 6), DataType(DataType.Password)]
            [Display(Name = "Hasło")]
            public string Password { get; set; }

            [DataType(DataType.Password), Compare("Password")]
            [Display(Name = "Potwierdź hasło")]
            public string ConfirmPassword { get; set; }

            // --- nowe pola dla czytelnika ---
            [Required]
            [Display(Name = "Imię i nazwisko")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Miasto")]
            public string City { get; set; }

            [Required]
            [Display(Name = "Kod pocztowy")]
            public string Code { get; set; }

            [Required]
            [Display(Name = "Ulica i numer")]
            public string Street { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (!ModelState.IsValid)
                return Page();

            // 1) stwórz usera
            var user = Activator.CreateInstance<IdentityUser>();
            await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

            var result = await _userManager.CreateAsync(user, Input.Password);
            if (!result.Succeeded)
            {
                foreach (var e in result.Errors)
                    ModelState.AddModelError(string.Empty, e.Description);
                return Page();
            }

            _logger.LogInformation("User created a new account with password.");

            // 2) przydziel rolę
            await _userManager.AddToRoleAsync(user, "User");

            // 3) stwórz i zachowaj Reader powiązanego z user.Id
            var reader = new Reader
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                Name = Input.Name,
                City = Input.City,
                Code = Input.Code,
                Street = Input.Street
            };
            _db.Readers.Add(reader);
            await _db.SaveChangesAsync();

            // 4) wyślij mail potwierdzający
            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = userId, code = code, returnUrl },
                protocol: Request.Scheme);

            await _emailSender.SendEmailAsync(Input.Email, "Potwierdź swój email",
                $"Potwierdź konto <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>klikając tutaj</a>.");

            if (_userManager.Options.SignIn.RequireConfirmedAccount)
                return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl });

            await _signInManager.SignInAsync(user, isPersistent: false);
            return LocalRedirect(returnUrl);
        }
    }
}
