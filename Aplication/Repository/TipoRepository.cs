using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Aplication.Repository
{
    public class TipoRepository : IRepository<Tipo>
    {
        AplicationDbContext _context;
        public TipoRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Tipo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tipo entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tipo> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tipo> Get(Expression<Func<Tipo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Tipo GetById(Expression<Func<Tipo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Tipo entity)
        {
            throw new NotImplementedException();
        }
    }
}
