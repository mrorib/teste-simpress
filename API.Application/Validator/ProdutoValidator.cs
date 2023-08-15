using API.Application.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Validator
{
    public class ProdutoValidator : AbstractValidator<ProdutoVM>
    {
        public ProdutoValidator()
        {
            RuleFor(produto => produto.nome).Length(2, 250);
            RuleFor(produto => produto.descricao).Length(2, 250);
            RuleFor(produto => produto.ativo).NotEmpty();
            RuleFor(produto => produto.perecivel).NotEmpty();
            RuleFor(produto => produto.categoriaProduto.id).NotNull();
        }
    }
}
