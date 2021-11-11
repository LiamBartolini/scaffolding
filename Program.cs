using bartolini.liam._5h.scaffolding.Models;

StudentiClassi db = new();

db.Aulas.Add(
    new Aula {
        IdAula = 2,
        Nome = "1.17",
        FkIdClasse = 2,
        IdDocente = 2
    }
);

db.Classes.Add(
    new Classe {
        Idclasse = 2,
        AnnoScolastico = "2021/2022",
        Anno = "5",
        Sezione = "H"
    }
);

db.Studentes.Add(
    new Studente {
        Idstudente = 3,
        CodiceFiscale = "tstcdoe",
        Nome = "test",
        Cognome = "code",
        FkIdClasse = 2
    }
);

db.Studentes.Add(
    new Studente {
        Idstudente = 4,
        CodiceFiscale = "abcde",
        Nome = "abc",
        Cognome = "de",
        FkIdClasse = 1
    }
);

db.SaveChanges();