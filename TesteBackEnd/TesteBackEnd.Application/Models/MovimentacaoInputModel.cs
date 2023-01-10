using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBackEnd.Application.Models
{
    public class MovimentacaoInputModel
    {
        public int Id { get; set; }
        public string CodigoConteiner { get; set; }
        public int TipoMov { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFinal { get; set; }
    }
}
