using BusinessLogic.Interface;
using Dominio;
using InfraEstrutura.Interface;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Servico
{
    public class RequisitoService : IDisposable
    {
        UnitOfWork _uow;
        public RequisitoService()
        {
            _uow = new UnitOfWork();
        }
        public IEnumerable<Requisito> ListarRequisito()
        {
            return _uow.RequisitoRepository.Get();
        }
        public void AdicionarRequisito(Requisito cli)
        {
            _uow.RequisitoRepository.Add(cli);
            _uow.Commit();
        }
        public void ExcluirRequisito(Requisito cli)
        {
            _uow.RequisitoRepository.Delete(cli);
            _uow.Commit();
        }
        public void AlterarRequisito(Requisito cli)
        {
            _uow.RequisitoRepository.Update(cli);
            _uow.Commit();
        }
        public Requisito GetRequisitoPorId(int codigo)
        {
            return _uow.RequisitoRepository.GetById(c => c.codReq == codigo);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
