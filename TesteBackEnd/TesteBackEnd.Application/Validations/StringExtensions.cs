using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TesteBackEnd.Application.Validations
{
    public static class StringExtensions
    {
        public static bool ValidarCodigo(this string codigo)
        {
            var pattern = "[a-zA-Z]{4}[0-9]{7}";
            return Regex.Match(codigo,pattern).Success;
        }
    }
}
