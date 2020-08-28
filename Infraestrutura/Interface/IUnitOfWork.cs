using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstrutura.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Projeto> ProjetoRepository { get; }
        IRepository<Modulo> ModuloRepository { get; }
        IRepository<Requisito> RequisitoRepository { get; }
        IRepository<Tipo> TipoRepository { get; }

        void Commit();
        void Dispose();
    }
}
