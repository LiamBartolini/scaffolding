using System;
using System.Collections.Generic;

namespace bartolini.liam._5h.scaffolding.Models
{
    public partial class Materia
    {
        public Materia()
        {
            Docentes = new HashSet<Docente>();
        }

        public long IdMateria { get; set; }
        public string Nome { get; set; } = null!;
        public long FkIdClasse { get; set; }

        public virtual Classe FkIdClasseNavigation { get; set; } = null!;
        public virtual ICollection<Docente> Docentes { get; set; }
    }
}
