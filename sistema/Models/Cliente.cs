using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Models
{
    public class Cliente
    {
        //[Key]
        public int Id { get; set; }
        [Display(Name="NOME")]
        [MaxLength(200, ErrorMessage ="Não pode ter mais que 200 caracteres.")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public double CPF { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Cliente(){}

        public Cliente(int id, string nome, string email, double cPF)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cPF;
        }
        public void AddPedido(Pedido p)
        {
            Pedidos.Add(p);
        }
        public void RemovePedido(Pedido p)
        {
            Pedidos.Remove(p);
        }
        public double Total()
        {
            return Pedidos.Where(p => p.Preco > 0).Sum(p => p.Preco);
        }
    }
}
