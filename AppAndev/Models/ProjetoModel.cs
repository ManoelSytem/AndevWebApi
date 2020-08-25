using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppAndev.Models
{
    public class ProjetoModel
    {
        [DisplayName("Título")]
        public string titulo { get; set; }
        [DisplayName("Descrição")]
        public string descricao { get; set; }
        
    }
}
