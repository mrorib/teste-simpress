using API.Application.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Validator
{
    public class CategoriaProdutoValidator : AbstractValidator<CategoriaProdutoVM>
    {
        public CategoriaProdutoValidator()
        {
            RuleFor(categoria => categoria.nome).Length(2, 250);
            RuleFor(categoria => categoria.descricao).Length(2, 250);
            RuleFor(categoria => categoria.ativo).NotEmpty();
        }
    }
}
