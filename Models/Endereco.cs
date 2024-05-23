using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBuscaCep.Models
{
    public class Endereco
    {
        public string idLogradouro { get; set; }

        public int idCidade { get; set; }

        public string tipo { get; set; }

        public string descricao { get; set; }

        public string uf { get; set; }

        public string complemento { get; set; }

        public string descricaoSemNumero { get; set; }

        public string descricaoCidade { get; set; }

        public string codigoCidadeIBGE { get; set; }
        public string descricaoBairro { get; set; }

        public string rows { get; set; }
        public int CEP { get; set; }

        public string UF { get; set; }



    }
}
