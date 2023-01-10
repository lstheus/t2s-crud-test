using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Core.Entities;
using TesteBackEnd.Core.Interfaces;
using TesteBackEnd.Infra.Context;

namespace TesteBackEnd.Infra.Repositories
{
    public class ConteinerRepository : IConteinerRepository
    {
        private readonly TesteContext context;
        public ConteinerRepository(TesteContext _context)
        {
            context = _context;
        }
        public void Delete(Conteiner conteiner)
        {
            context.conteiners.Remove(conteiner);
            context.SaveChanges();
        }

        public List<Conteiner> Get()
        {
            return context.conteiners.ToList();
        }

        public Conteiner GetById(string codigo)
        {
            var conteiner = context.conteiners.Where(c=> c.Codigo == codigo).AsNoTracking().Include(c => c.movimentacoes).FirstOrDefault();
            return conteiner;
        }

        public void Post(Conteiner conteiner)
        {

            context.conteiners.Add(conteiner);
            context.SaveChanges();
        }

        public void Put(Conteiner conteiner)
        {
            context.conteiners.Entry(conteiner).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
