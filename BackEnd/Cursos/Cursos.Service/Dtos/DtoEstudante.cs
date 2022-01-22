
namespace Cursos.Service.Dtos
{
    public class DtoEstudante
    {

        public DtoEstudante(int id, string nome, string cpf, string email, string endereco)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Endereco = endereco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Sexo { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
