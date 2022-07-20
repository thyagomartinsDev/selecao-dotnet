using System;

namespace Cursos.Domain.Model
{
    public class EntidadeBase
    {
        public bool EhAtivo { get; set; }
        public DateTime CriadoEm => DateTime.Now;
        public DateTime? AtualizadoEm { get; set; }
        public DateTime? DeletadoEm { get; set; }
        public bool EhDeletado { get; set; }
    }
}
