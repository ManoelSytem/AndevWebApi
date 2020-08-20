using BusinessLogic.Interface;
using BusinessLogic.Servico;
using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLogic.Repository
{
    public class RequisitoRepository : IRepository<Requisito>, IRequisito
    {
        AplicationDbContext _context;
        public RequisitoRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Requisito entity)
        {
            _context.Requisito.Add(entity);
        }
        public void Delete(Requisito entity)
        {
            _context.Requisito.Remove(entity);
        }
        public IEnumerable<Requisito> Get()
        {
            return _context.Requisito.ToList();
        }
        public void Update(Requisito entity)
        {
            _context.Requisito.Update(entity);
        }
        public IEnumerable<Requisito> Get(Expression<Func<Requisito, bool>> predicate)
        {
            return _context.Requisito.Where(predicate);
        }
        public Requisito GetById(Expression<Func<Requisito, bool>> predicate)
        {
            return _context.Requisito.FirstOrDefault(predicate);
        }

        //Metodo Negocio
        public IEnumerable<Requisito> GetRequisito()
        {
            return Get().OrderBy(c => c.codReq).ToList();
        }
    }
}
