using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Models;

namespace TesteBackEnd.Application.Validations
{
    public class ClienteValidation : AbstractValidator<ClienteInputModel>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Nome)
             .NotEmpty()
             .NotNull()
             .MaximumLength(45);
        }
    }
}
