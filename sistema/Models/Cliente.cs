using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Models
{
    public class Cliente
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Seu Nome")]
        [Display(Name = "NOME")]
        [MaxLength(60, ErrorMessage = "Não pode ter mais que {1}: caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Digite seu CPF")]
        public double CPF { get; set; }

        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public Cliente(){}

        public Cliente(int id, string nome, string email, double Cpf)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = Cpf;
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
