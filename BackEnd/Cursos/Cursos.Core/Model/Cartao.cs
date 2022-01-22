﻿using Cursos.Core.Interfaces;

namespace Cursos.Core.Model
{
    public class Cartao : EntidadeBase, IIdentityEntity
    {

        public Cartao(int id, string numeroCartao, string codigoCartao, string validadeCartao, string nomeTitular, string bandeiraCartao)
        {
            Id = id;
            NumeroCartao = numeroCartao;
            CodigoCartao = codigoCartao;
            ValidadeCartao = validadeCartao;
            NomeTitular = nomeTitular;
            BandeiraCartao = bandeiraCartao;
        }

        public int Id { get; set; }
        public string NumeroCartao { get; set; }
        public string ValidadeCartao { get; set; }
        public string CodigoCartao { get; set; }
        public string NomeTitular { get; set; }
        public string BandeiraCartao { get; set; }
    }
}
