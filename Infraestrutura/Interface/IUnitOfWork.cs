using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstrutura.Interface
{
    public interface IUnitOfWork<T> where T : class
    {
        IRepository<T> Repository { get; }
        void Commit();
        void Dispose();
    }
}
