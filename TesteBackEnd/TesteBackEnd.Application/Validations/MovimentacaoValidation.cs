using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Models;

namespace TesteBackEnd.Application.Validations
{
    public class MovimentacaoValidation : AbstractValidator<MovimentacaoInputModel>
    {
        public MovimentacaoValidation()
        {
            RuleFor(c => c.CodigoConteiner)
               .NotEmpty()
               .NotNull()
               .MaximumLength(11)
               .Must(c => c.ValidarCodigo());
            RuleFor(c => c.TipoMov)
               .NotEmpty()
               .NotNull()
               .LessThanOrEqualTo(7);
            RuleFor(c => c.DtFinal)
               .NotEmpty()
               .NotNull();
            RuleFor(c => c.DtInicio)
             .NotEmpty()
             .NotNull();
        }
    }
}
