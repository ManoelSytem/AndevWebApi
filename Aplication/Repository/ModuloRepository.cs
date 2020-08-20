using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Aplication.Repository
{
    public class ModuloRepository : IRepository<Modulo>
    {
        AplicationDbContext _context;
        public ModuloRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Modulo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Modulo entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modulo> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modulo> Get(Expression<Func<Modulo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Modulo GetById(Expression<Func<Modulo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Modulo entity)
        {
            throw new NotImplementedException();
        }
    }
}
