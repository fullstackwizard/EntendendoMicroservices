namespace PedidoCrud.Models // Certifique-se de que o namespace é este!
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string TipoProduto { get; set; }
    }
}
