using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Requisito
    {
        public int codReq { get; set; }
        public string nome { get; set; }
        public string autor { get; set; }
        public int codModulo { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataUpdate { get; set; }
        public int codTipo { get; set; }
        public string descricao { get; set; }
        public int precondicaoReq { get; set; }
    }
}
