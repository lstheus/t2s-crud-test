using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Core.Interfaces
{
    public interface IMovimentacaoRepository
    {
        public List<Movimentacao> Get();
        public Movimentacao GetById(int id);
        public void Post(Movimentacao movimentacao);
        public void Put(Movimentacao movimentacao);
        public void Delete(Movimentacao movimentacao);
    }
}
