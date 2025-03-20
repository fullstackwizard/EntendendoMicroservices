using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PedidoCrud.Models // Certifique-se de que o namespace é este!
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public decimal Preco { get; set; }
        public string TipoProduto { get; set; } = string.Empty;

        public Produto(string nome, string tipoProduto)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        TipoProduto = tipoProduto ?? throw new ArgumentNullException(nameof(tipoProduto));
    }
    }

}
