using System;
using Cursos.Core.Interfaces;

namespace Cursos.Core.Model
{
    public class Matricula : EntidadeBase, IIdentityEntity
    {
        public Matricula(int id, int codigoCurso, int codigoEstudante, DateTime dataMatricula)
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
