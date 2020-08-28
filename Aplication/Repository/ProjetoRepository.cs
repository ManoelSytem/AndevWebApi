using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLogic.Repository
{
    public class ProjetoRepository : IRepository<Projeto>
    {
        AplicationDbContext _context;
        public ProjetoRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Projeto entity)
        {
            _context.Projeto.Add(entity);
        }

        public void Delete(Projeto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projeto> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projeto> Get(Expression<Func<Projeto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Projeto GetById(Expression<Func<Projeto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Projeto entity)
        {
            throw new NotImplementedException();
        }
    }
}
