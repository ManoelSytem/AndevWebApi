using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interface
{
    interface IRequisito: IRepository<Requisito>
    {
        IEnumerable<Requisito> GetRequisito();
    }
}
