using System;
using System.Collections.Generic;

namespace bartolini.liam._5h.scaffolding.Models
{
    public partial class Classe
    {
        public Classe()
        {
            Aulas = new HashSet<Aula>();
            Materia = new HashSet<Materia>();
            Studentes = new HashSet<Studente>();
        }

        public long Idclasse { get; set; }
        public string AnnoScolastico { get; set; } = null!;
        public string Anno { get; set; } = null!;
        public string Sezione { get; set; } = null!;

        public virtual ICollection<Aula> Aulas { get; set; }
        public virtual ICollection<Materia> Materia { get; set; }
        public virtual ICollection<Studente> Studentes { get; set; }
    }
}
