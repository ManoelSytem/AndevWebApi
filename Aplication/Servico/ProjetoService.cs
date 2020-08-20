using BusinessLogic.Interface;
using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class ProjetoService : IDisposable, IProjeto
    {
        IUnitOfWork<Projeto> _uow;
        public ProjetoService(IUnitOfWork<Projeto> uow)
        {
            _uow = uow;
        }
        public IEnumerable<Projeto> Listar()
        {
            return _uow.Repository.Get();
        }
        public void Adicionar(Projeto cli)
        {
            _uow.Repository.Add(cli);
            _uow.Commit();
        }
        public void Excluir(Projeto cli)
        {
            _uow.Repository.Delete(cli);
            _uow.Commit();
        }
        public void Alterar(Projeto cli)
        {
            _uow.Repository.Update(cli);
            _uow.Commit();
        }
        public List<Projeto> ObterProjetoPorIdCliente(int IdUser)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
