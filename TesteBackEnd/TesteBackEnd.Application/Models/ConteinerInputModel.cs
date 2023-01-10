using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBackEnd.Application.Models
{
    public class ConteinerInputModel
    {
        public string Codigo { get; set; }
        public int ClienteId { get; set; }
        public int Status { get; set; }
        public int Tipo { get; set; }
        public int Categoria { get; set; }
    }
}
