using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interface
{
    interface IRequisitoRepository : IRepository<Requisito>
    {
        IEnumerable<Requisito> GetRequisito();
    }
}
