namespace API.Domain.Entities
{
    public class Produto
    {
        public Produto() { }

        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public bool ativo { get; set; }
        public bool perecivel { get; set; }
        public CategoriaProduto categoriaProduto { get; set; }
    }
}
