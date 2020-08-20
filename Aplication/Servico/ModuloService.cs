using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class ModuloService : IDisposable
    {
        IUnitOfWork<Modulo> _uow;
        public ModuloService(IUnitOfWork<Modulo> uow)
        {
            _uow = uow;
        }
        public IEnumerable<Modulo> Listar()
        {
            return _uow.Repository.Get();
        }
        public void Adicionar(Modulo cli)
        {
            _uow.Repository.Add(cli);
            _uow.Commit();
        }
        public void Excluir(Modulo cli)
        {
            _uow.Repository.Delete(cli);
            _uow.Commit();
        }
        public void Alterar(Modulo cli)
        {
            _uow.Repository.Update(cli);
            _uow.Commit();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
