# LibSys – System Zarządzania Biblioteką

## 🚀 Wprowadzenie

**LibSys** to lekka, responsywna aplikacja webowa ułatwiająca obsługę wypożyczeń książek zarówno „na miejscu”, jak i online.  
Oferuje:

- Zarządzanie katalogiem książek (definicje, okładki, liczniki egzemplarzy)  
- Tworzenie i śledzenie historii wypożyczeń  
- Automatyczne zmiany statusów książek przy wypożyczeniu/zwrocie  
- Rejestrację użytkowników z rolami `Admin` / `User`  
- Generowanie logów audytu operacji  

---

## 🎯 Główne funkcjonalności

1. **Zarządzanie encjami (CRUD)**  
   - Definicje książek, egzemplarze, czytelnicy, logi (tylko Admin)  
2. **Uwierzytelnianie i role**  
   - Rejestracja, logowanie, potwierdzenie e-mailem  
   - Role `Admin` (pełne uprawnienia) i `User` (wypożyczanie własnych książek)  
3. **Wypożyczanie**  
   - Online i stacjonarne  
   - Automatyczna zmiana statusu książki (`Available` ⇄ `Borrowed`)  
   - Historia z widocznym statusem i flagą `IsReturned`  
4. **Grupowanie i zliczanie**  
   - Pokazywanie liczby dostępnych egzemplarzy każdej definicji  
5. **Raporty i logi**  
   - Przechowywanie ścieżki zmian w `LogEntry` (metoda, encja, zmiany, czas, użytkownik)  

---

## 🛠️ Technologie i narzędzia

### Platforma i język  
- **.NET 7.0** – wydajna, cross-platformowa platforma do budowy aplikacji web  
- **C# 11** – silnie typowany, obiektowy język Microsoftu  

### Framework i ORM  
- **ASP.NET Core MVC & Razor** – lekki framework webowy z silnikiem szablonów Razor  
- **Entity Framework Core 7.0** – ORM z podejściem Code-First oraz migracjami  

### Tożsamość i bezpieczeństwo  
- **ASP.NET Core Identity** – zarządzanie użytkownikami, rolami, potwierdzeniem e-mailem  

### Front-end  
- **Bootstrap 5** – responsywne siatki i gotowe komponenty UI  
- **jQuery + DataTables** – zaawansowane tabele z sortowaniem, filtrowaniem i paginacją  

### Inne biblioteki / frameworki  
- **Swagger (Swashbuckle)** – automatyczna dokumentacja i testowanie API  
- **Postman** – rozwinięte testowanie i debugowanie zapytań HTTP  

### Narzędzia developerskie  
- **Visual Studio 2022** – IDE z debuggerem i menedżerem NuGet  
- **dotnet CLI** – konsolowe budowanie, migracje, uruchamianie  
- **Git & GitHub** – kontrola wersji i zdalne repozytorium  
- **Azure Data Studio / SSMS** – zarządzanie i zapytania do SQL Server  
- **Chrome DevTools** – analiza i debugowanie front-endu  

---

## ⚙️ Instalacja i uruchomienie

1. **Sklonuj repozytorium bądź pobierz**
2. **Uruchom aplikację**
3. **zastosuj migrację aby utworzyć bazę danych**
   ```bash
   Update-Database -Context ApplicationDbContext

---

## 🔑 Konto testowe
- **Email: admin@gmail.com
- **Hasło: AdminP@ssw0rd123!
   
