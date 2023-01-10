using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Interfaces;
using TesteBackEnd.Core.Entities;
using TesteBackEnd.Core.Interfaces;

namespace TesteBackEnd.Application.Services
{
    public class RelatorioService : IRelatorioService
    {
        private readonly IRelatorioRepository relatorioRepository;
        public RelatorioService(IRelatorioRepository relatorioRepository)
        {
            this.relatorioRepository = relatorioRepository;
        }
        public Relatorio Get()
        {
          var relatorio = relatorioRepository.Get();
            if (relatorio == null) throw new NullReferenceException();
            return relatorio;
        }
    }
}
