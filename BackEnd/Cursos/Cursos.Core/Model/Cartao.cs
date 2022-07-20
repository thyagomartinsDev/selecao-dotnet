using Cursos.Domain.Interfaces;

namespace Cursos.Domain.Model
{
    public class Cartao : EntidadeBase, IIdentityEntity
    {

        public Cartao(int id, string numeroCartao, string codigoCartao, string validadeCartao, string nomeTitular, string bandeiraCartao, int idEstudante)
        {
            Id = id;
            NumeroCartao = numeroCartao;
            CodigoCartao = codigoCartao;
            ValidadeCartao = validadeCartao;
            NomeTitular = nomeTitular;
            BandeiraCartao = bandeiraCartao;
            IdEstudante = idEstudante;
        }

        public int Id { get; set; }
        public string NumeroCartao { get; set; }
        public string ValidadeCartao { get; set; }
        public string CodigoCartao { get; set; }
        public string NomeTitular { get; set; }
        public string BandeiraCartao { get; set; }
        public int IdEstudante { get; set; }
    }
}
