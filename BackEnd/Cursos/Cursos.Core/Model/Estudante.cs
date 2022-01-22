using Cursos.Core.Interfaces;

namespace Cursos.Core.Model
{
    public class Estudante : EntidadeBase, IIdentityEntity
    {
        public Estudante(int id, string nome, string cpf, string endereco, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Email = email;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
