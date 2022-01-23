
using Cursos.Core.Interfaces;

namespace Cursos.Core.Model
{
    public class Curso : EntidadeBase, IIdentityEntity
    {
        public Curso(int id, string descricao, int duracaoCurso, int valorCurso)
        {
            Id = id;
            Descricao = descricao;
            DuracaoCurso = duracaoCurso;
            ValorCurso = valorCurso;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int DuracaoCurso { get; set; }
        public int ValorCurso { get; set; }
    }
}
