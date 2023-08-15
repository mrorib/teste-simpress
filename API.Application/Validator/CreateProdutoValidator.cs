using API.Application.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Validator
{
    public class CreateProdutoValidator : AbstractValidator<CreateProdutoVM>
    {
        public CreateProdutoValidator() 
        {
            RuleFor(produto => produto.nome).Length(2, 250);
            RuleFor(produto => produto.descricao).Length(2, 250);
            RuleFor(produto => produto.perecivel).NotEmpty();
            RuleFor(produto => produto.idCategoriaProduto).NotNull();
        }
    }
}
