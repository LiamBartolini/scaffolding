using System;
using System.Collections.Generic;

namespace bartolini.liam._5h.scaffolding.Models
{
    public partial class Studente
    {
        public long Idstudente { get; set; }
        public string CodiceFiscale { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public long? FkIdClasse { get; set; }

        public virtual Classe? FkIdClasseNavigation { get; set; }
    }
}
