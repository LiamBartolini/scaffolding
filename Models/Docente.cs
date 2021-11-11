using System;
using System.Collections.Generic;

namespace bartolini.liam._5h.scaffolding.Models
{
    public partial class Docente
    {
        public long IdDocente { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public long? FkIdMateria { get; set; }

        public virtual Materia? FkIdMateriaNavigation { get; set; }
    }
}
