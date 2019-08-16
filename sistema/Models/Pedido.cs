using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace sistema.Models
{
    public class Pedido
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; } = 0;
        [Display(Name = "Nome do Produto")]
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Pedido(int id, double preco, int quantidade, Cliente cliente)
        {
            Id = id;
            Preco = preco;
            Quantidade = quantidade;
            Cliente = cliente;
            ClienteId = Cliente.Id;
        }
        public void AddProduto(Produto p)
        {
            Produtos.Add(p);
        }
        public void RemoveProduto(Produto p)
        {
            Produtos.Remove(p);
        }
        public void QuantidadeProduto(int ? qnt, Produto prod)//teste sendo void para testar se funciona chamar somento a função
        {
           
        }

        public double TotalPedido(Produto p)
        {
            //foreach (Produto x in Produtos)
            //{
            //    x.Preco++;
            //};
            var totalP = Produtos.Sum(x => x.Preco);
            return totalP;
        }
    }
}