using System;

namespace Cursos.Service.Dtos
{
    public class DtoMatricula
    {
        public DtoMatricula(int codigoCurso, int codigoEstudante, DateTime dataMatricula)
        {
            CodigoCurso = codigoCurso;
            CodigoEstudante = codigoEstudante;
            DataMatricula = dataMatricula;
        }

        public DtoMatricula(int id, int codigoCurso, int codigoEstudante, DateTime dataMatricula)
        {
            Id = id;
            CodigoCurso = codigoCurso;
            CodigoEstudante = codigoEstudante;
            DataMatricula = dataMatricula;
        }

        public int Id { get; set; }
        public int CodigoEstudante { get; set; }
        public int CodigoCurso { get; set; }
        public DateTime DataMatricula { get; set; }
    }
}
