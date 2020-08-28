using Dominio;
using InfraEstrutura.Interface;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class ModuloService : IDisposable
    {
        UnitOfWork _uow;
        public ModuloService()
        {
            _uow = new UnitOfWork();
        }
        public IEnumerable<Modulo> Listar()
        {
            return _uow.ModuloRepository.Get();
        }
        public void Adicionar(Modulo cli)
        {
            _uow.ModuloRepository.Add(cli);
            _uow.Commit();
        }
        public void Excluir(Modulo cli)
        {
            _uow.ModuloRepository.Delete(cli);
            _uow.Commit();
        }
        public void Alterar(Modulo cli)
        {
            _uow.ModuloRepository.Update(cli);
            _uow.Commit();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
