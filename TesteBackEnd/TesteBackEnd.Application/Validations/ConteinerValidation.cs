using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Models;

namespace TesteBackEnd.Application.Validations
{
    public class ConteinerValidation : AbstractValidator<ConteinerInputModel>
    {
        public ConteinerValidation()
        {
            RuleFor(c => c.Codigo)
                .NotEmpty()
                .NotNull()
                .MaximumLength(11)
                .Must(c => c.ValidarCodigo());
            RuleFor(c => c.Status)
                .NotEmpty()
                .NotNull()
                .LessThanOrEqualTo(2);
            RuleFor(c => c.Tipo)
               .NotEmpty()
               .NotNull()
               .LessThanOrEqualTo(2);
            RuleFor(c => c.ClienteId)
               .NotEmpty()
               .NotNull();
            RuleFor(c => c.Categoria)
               .NotEmpty()
               .NotNull()
               .LessThanOrEqualTo(2);
        }
    }
}
