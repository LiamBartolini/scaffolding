using System;
using System.Collections.Generic;

namespace bartolini.liam._5h.scaffolding.Models
{
    public partial class Aula
    {
        public long IdAula { get; set; }
        public string Nome { get; set; } = null!;
        public long FkIdClasse { get; set; }
        public long IdDocente { get; set; }

        public virtual Classe FkIdClasseNavigation { get; set; } = null!;
    }
}
