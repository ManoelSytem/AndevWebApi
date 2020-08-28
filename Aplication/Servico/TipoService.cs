using Dominio;
using InfraEstrutura.Interface;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class TipoService : IDisposable
    {
        UnitOfWork _uow;
        public TipoService()
        {
            _uow = new UnitOfWork();
        }
        public IEnumerable<Tipo> Listar()
        {
            return _uow.TipoRepository.Get();
        }
        public void Adicionar(Tipo cli)
        {
            _uow.TipoRepository.Add(cli);
            _uow.Commit();
        }
        public void Excluir(Tipo cli)
        {
            _uow.TipoRepository.Delete(cli);
            _uow.Commit();
        }
        public void Alterar(Tipo cli)
        {
            _uow.TipoRepository.Update(cli);
            _uow.Commit();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
