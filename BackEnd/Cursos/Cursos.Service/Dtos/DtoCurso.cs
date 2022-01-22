
namespace Cursos.Service.Dtos
{
    public class DtoCurso
    {
        public DtoCurso(int id, string descricao, int duracaoCurso, int valorCurso)
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
