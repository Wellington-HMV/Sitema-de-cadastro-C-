using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema.Models
{
    public class Produto
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome do Produto")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Display(Name = "Preço do Produto")]
        [Required(ErrorMessage = "Por favor informe o {0}")]
        [Range(0.00, 99999.00, ErrorMessage = "O valor de ser maior que {1} e menor que {2}")]
        public double Preco { get; set; }

        [Display(Name = "Quantidade de produtos")]
        [Range(0.0, 100.0, ErrorMessage ="Entre com o valor de {1} a {2}")]
        public int Quantidade { get; set; } = 0;


        public Produto(int id, string nome, double preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}