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
    public class MovimentacaoRepository : IMovimentacaoRepository
    {

        private readonly TesteContext context;
        public MovimentacaoRepository(TesteContext _context)
        {
            context = _context;
        }
        public void Delete(Movimentacao movimentacao)
        {
            context.movimentacoes.Remove(movimentacao);
            context.SaveChanges();
        }

        public List<Movimentacao> Get()
        {
            return context.movimentacoes.ToList();
        }

        public Movimentacao GetById(int id)
        {
            var movimentacao = context.movimentacoes.Where(m=> m.Id == id).AsNoTracking().FirstOrDefault();
            return movimentacao;
        }

        public void Post(Movimentacao movimentacao)
        {

            context.movimentacoes.Add(movimentacao);
            context.SaveChanges();
        }

        public void Put(Movimentacao movimentacao)
        {
            context.movimentacoes.Entry(movimentacao).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
