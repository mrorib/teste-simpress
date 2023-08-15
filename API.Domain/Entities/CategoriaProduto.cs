namespace API.Domain.Entities
{
    public class CategoriaProduto
    {
        public CategoriaProduto() { }

        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public bool ativo { get; set; }
    }
}
