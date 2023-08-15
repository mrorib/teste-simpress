using API.Application.ViewModels;

namespace API.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutosVM> GetProdutos();
        Task<ProdutoVM> CreateProduto(CreateProdutoVM createProduto);
        Task<ProdutoVM> EditProduto(ProdutoVM editProduto);
        Task<CategoriasProdutoVM> GetCategoriasProdutos();
    }
}
