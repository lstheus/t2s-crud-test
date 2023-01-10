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
    public class RelatorioRepository : IRelatorioRepository
    {
        private readonly TesteContext context;
        public RelatorioRepository(TesteContext _context)
        {
            context = _context;
        }
        public Relatorio Get()
        {
            var totalMov = context.movimentacoes.ToList().Count();
            var totalCont = context.conteiners.ToList().Count();

            var totalImp = context.conteiners.Where(c => c.Categoria == 1).Count();

            var totalExp = context.conteiners.Where(c => c.Categoria == 2).Count();
            var movimentacoes = context.movimentacoes.OrderBy(c=> c.Id).ThenBy(c=> c.TipoMov).ToList();
            Relatorio relatorio = new Relatorio(totalMov,totalCont,totalImp,totalExp,movimentacoes);
            return relatorio;

        }


    }
}
