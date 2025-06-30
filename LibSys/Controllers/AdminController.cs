using LibSys.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibSys.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: /Admin/RegisterAdmin
        [HttpGet]
        public IActionResult RegisterAdmin() => View();

        // POST: /Admin/RegisterAdmin
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAdmin(RegisterAdminViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            // 1) Utworzenie konta
            var user = new IdentityUser { UserName = vm.Email, Email = vm.Email };
            var createResult = await _userManager.CreateAsync(user, vm.Password);
            if (!createResult.Succeeded)
            {
                foreach (var error in createResult.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
                return View(vm);
            }

            // 2) Automatyczne potwierdzenie e-maila
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmResult = await _userManager.ConfirmEmailAsync(user, token);
            if (!confirmResult.Succeeded)
            {
                // jeśli chcesz, możesz to zalogować lub dodać ModelState
                ModelState.AddModelError(string.Empty, "Nie udało się potwierdzić emaila.");
                return View(vm);
            }

            // 3) Przypisanie roli Admin
            var roleResult = await _userManager.AddToRoleAsync(user, "Admin");
            if (!roleResult.Succeeded)
            {
                foreach (var error in roleResult.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
                return View(vm);
            }

            // 4) Przekierowanie po sukcesie
            return RedirectToAction("Index", "Home");
        }
    }
}