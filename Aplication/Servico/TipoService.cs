using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class TipoService : IDisposable
    {
        IUnitOfWork<Tipo> _uow;
        public TipoService(IUnitOfWork<Tipo> uow)
        {
            _uow = uow;
        }
        public IEnumerable<Tipo> Listar()
        {
            return _uow.Repository.Get();
        }
        public void Adicionar(Tipo cli)
        {
            _uow.Repository.Add(cli);
            _uow.Commit();
        }
        public void Excluir(Tipo cli)
        {
            _uow.Repository.Delete(cli);
            _uow.Commit();
        }
        public void Alterar(Tipo cli)
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
