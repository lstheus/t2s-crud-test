using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Core.Interfaces
{
    public interface IRelatorioRepository
    {
        public Relatorio Get();
    }
}
