using API.Application.Interfaces;
using API.Application.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProdutoStore.Web.Mvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private IProdutoService _produtoService;
        private IValidator<ProdutoVM> _validatorProduto;
        private IValidator<CreateProdutoVM> _validatorCreateProduto;

        public ProdutoController(IProdutoService produtoService, IValidator<ProdutoVM> validatorProduto, IValidator<CreateProdutoVM> validatorCreateProduto)
        {
            _produtoService = produtoService;
            _validatorProduto = validatorProduto;
            _validatorCreateProduto = validatorCreateProduto;
    }

        [HttpGet("~/index")]
        public async Task<IActionResult> Index()
        {
            ProdutosVM model = await _produtoService.GetProdutos();
            return View(model);
        }

        [HttpPost("~/create")]
        public async Task<IActionResult> PostProduto(CreateProdutoVM produto)
        {
            ValidationResult result = await _validatorCreateProduto.ValidateAsync(produto);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View(result);
            }

            ProdutoVM model = await _produtoService.CreateProduto(produto);
            return View(model);
        }

        [HttpPost("~/atualizar-produto/{id}")]
        public async Task<IActionResult> PutProduto(int id, [FromBody] ProdutoVM produto)
        {
            produto.id = id;

            ValidationResult result = await _validatorProduto.ValidateAsync(produto);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View(result);
            }

            ProdutoVM model = await _produtoService.EditProduto(produto);
            return View(model);
        }

        [HttpGet("~/categorias-produto")]
        public async Task<IActionResult> GetCategoriasProduto()
        {
            CategoriasProdutoVM model = await _produtoService.GetCategoriasProdutos();
            return View(model);
        }
    }
}
