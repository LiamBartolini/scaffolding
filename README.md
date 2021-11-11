# scaffolding
using dotnet ef scaffolding ... on StudentiClassi.db

Basic scaffolding operation onto a db sqlite

|Framework | .NET6 |
|----------|-------|
|C# | 9 |

An piece of code for example:
```c#
db.Studentes.Add(
    new Studente {
        Idstudente = 3,
        CodiceFiscale = "tstcdoe",
        Nome = "test",
        Cognome = "code",
        FkIdClasse = 2
    }
);
```
allow to add a new `Studente` into db with his property

using:
```c#
db.SaveChanges();
```
you persist changes onto db

---
Credits:  
@LiamBartolini
