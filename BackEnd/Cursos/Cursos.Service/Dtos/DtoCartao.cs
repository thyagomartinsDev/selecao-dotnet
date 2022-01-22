
namespace Cursos.Service.Dtos
{
    public class DtoCartao
    {
        public DtoCartao(int id, string numeroCartao, string codigoCartao, string validadeCartao, string nomeTitular, string bandeiraCartao, int idEstudante)
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
