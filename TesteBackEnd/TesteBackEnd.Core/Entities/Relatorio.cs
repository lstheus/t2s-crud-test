using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBackEnd.Core.Entities
{
    public class Relatorio
    {
        public Relatorio(int totalMov, int totalConteiner, int totalImportacao, int totalExportacao, IEnumerable<Movimentacao> movimentacoes)
        {
            TotalMov = totalMov;
            TotalConteiner = totalConteiner;
            TotalImportacao = totalImportacao;
            TotalExportacao = totalExportacao;
            this.movimentacoes = movimentacoes;
        }

        public int TotalMov { get; set; }
        public int TotalConteiner { get; set; }
        public int TotalImportacao { get; set; }
        public int TotalExportacao { get; set; }
        public IEnumerable<Movimentacao>movimentacoes { get; set; }
    }
}
