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
        IUnitOfWork<Requisito> _uow;
        public RequisitoService(IUnitOfWork<Requisito> uow)
        {
            _uow = uow;
        }

        public IEnumerable<Requisito> ListarRequisito()
        {
            return _uow.Repository.Get();
        }
        public void AdicionarRequisito(Requisito cli)
        {
            _uow.Repository.Add(cli);
            _uow.Commit();
        }
        public void ExcluirRequisito(Requisito cli)
        {
            _uow.Repository.Delete(cli);
            _uow.Commit();
        }
        public void AlterarRequisito(Requisito cli)
        {
            _uow.Repository.Update(cli);
            _uow.Commit();
        }
        public Requisito GetRequisitoPorId(int codigo)
        {
            return _uow.Repository.GetById(c => c.codReq == codigo);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
