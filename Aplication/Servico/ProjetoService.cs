using BusinessLogic.Interface;
using Dominio;
using InfraEstrutura.Interface;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class ProjetoService : IDisposable, IProjeto
    {
        UnitOfWork _uow;
        public ProjetoService()
        {
            _uow = new UnitOfWork();
        }
        public IEnumerable<Projeto> Listar()
        {
            return _uow.ProjetoRepository.Get();
        }
        public void Adicionar(Projeto cli)
        {
            _uow.ProjetoRepository.Add(cli);
            _uow.Commit();
        }
        public void Excluir(Projeto cli)
        {
            _uow.ProjetoRepository.Delete(cli);
            _uow.Commit();
        }
        public void Alterar(Projeto cli)
        {
            _uow.ProjetoRepository.Update(cli);
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
