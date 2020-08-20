using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstrutura.Repository
{
    
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class, IDisposable
    {
        public AplicationDbContext _context;
        private RepositoryGeneric<T> _repository;
        public UnitOfWork(AplicationDbContext context)
        {
            _context = context;
        }
        public UnitOfWork()
        {
            _context = new AplicationDbContext();
        }
        public IRepository<T> Repository
        {
            get
            {
                return _repository = _repository ?? new RepositoryGeneric<T>(_context);
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
