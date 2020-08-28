using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstrutura.Repository
{

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public AplicationDbContext _context;
        private RepositoryGeneric<Projeto> _repository;
        private RepositoryGeneric<Modulo> _moduloRepository;
        private RepositoryGeneric<Requisito> _requisitoRepository;
        private RepositoryGeneric<Tipo> _tipoRepository;

        public UnitOfWork(AplicationDbContext context)
        {
            _context = context;
        }
        public UnitOfWork()
        {
            _context = new AplicationDbContext();
        }
        public IRepository<Projeto> ProjetoRepository
        {
            get
            {
                return _repository = _repository ?? new RepositoryGeneric<Projeto>(_context);
            }
        }

        public IRepository<Modulo> ModuloRepository
        {
            get
            {
                return _moduloRepository = _moduloRepository ?? new RepositoryGeneric<Modulo>(_context);
            }
        }

        public IRepository<Requisito> RequisitoRepository
        {
            get
            {
                return _requisitoRepository = _requisitoRepository ?? new RepositoryGeneric<Requisito>(_context);
            }
        }

        public IRepository<Tipo> TipoRepository
        {
            get
            {
                return _tipoRepository = _tipoRepository ?? new RepositoryGeneric<Tipo>(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
