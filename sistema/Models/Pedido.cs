using System.Collections.Generic;

namespace sistema.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

        public Pedido(int id, double preco)
        {
            Id = id;
            Preco = preco;
        }
        public void AddProduto(Produto p)
        {
            Produtos.Add(p);
        }
        public void RemoveProduto(Produto p)
        {
            Produtos.Remove(p);
        }

        public double TotalPedido(Produto p)
        {
            return p.Preco++ ;
        }
    }
}