# Password Manager

## Program Leírása
Ez a C# Winform alkalmazás egy jelszókezelő alkalmazást valósít meg, amely a felhasználók jelszavait biztonságosan tárolja és kezeli. Az alkalmazás az SQLite adatbázist használja az adatok tárolására.

Ez a projekt a "Az Alkalmazásfejlesztés 2" kurzusra készült, és különböző funkcionalitásokat kínál a felhasználók számára, beleértve a bejelentkezést, regisztrációt, új jelszó-vault-ok hozzáadását és törlését.

## Funkcionalitások
Az alkalmazás számos fontos funkcionalitást tartalmaz:

- Bejelentkezés: A felhasználók képesek bejelentkezni a korábban regisztrált fiókjukkal.
- Regisztráció: Új felhasználók könnyedén regisztrálhatnak a rendszerbe, hogy használhassák a jelszókezelőt.
- Vault-ok kezelése: A felhasználók új jelszó-vault-okat hozhatnak létre, és törölhetik őket az alkalmazásban.

## Technikai Részletek
A projekt a következő technikai elemeket tartalmazza:

- C# Winform alkalmazás: Az alkalmazás egy felhasználóbarát grafikus felületen keresztül érhető el.
- SQLite adatbázis: Az adatok biztonságos tárolásához az alkalmazás SQLite adatbázist használ.
- Multi-Module Alkalmazás: Az alkalmazás több modulból áll, ami lehetővé teszi a funkcionalitás könnyű bővítését és karbantartását.
- Data Access Object (DAO): Az alkalmazás az adatbázis-hozzáférést külön DAO rétegen keresztül valósítja meg, ami növeli az alkalmazás rugalmasságát és karbantarthatóságát.

### Jelszavak Biztonságos Tárolása
Az alkalmazás a jelszavakat hashelve menti az adatbázisba, hogy növelje a biztonságot. Emellett a weboldalakhoz tartozó jelszavak kódolva tárolódnak, és az email cím szolgál kulcsként a kódoláshoz.

## Telepítés
1. Clone-ozd a projektet a saját gépedre.
2. Nyisd meg a projektet a Visual Studio vagy egy másik C# fejlesztőeszközben.
3. Fordítsd és futtasd az alkalmazást.

## Felhasználói Útmutató
Az alkalmazás használatához olvasd el a mellékelt felhasználói útmutatót.

---
