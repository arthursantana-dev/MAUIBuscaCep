using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBuscaCep.Models
{
    internal class Cidade
    {
        public int idCidade {  get; set; }
        public int descricao { get; set; }
        public int UF { get; set; }
        public int codigoIBGE { get; set; }
        public int DDD { get; set; }
    }
}
