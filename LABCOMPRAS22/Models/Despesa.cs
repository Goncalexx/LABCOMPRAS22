using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace LABCOMPRAS22.Models
{
    public class Despesa
    {
        private string nomeDespesa;
        private int quantidade;
        private double valor;
        private string categoria;
        private bool pago;

        [Required(ErrorMessage= "Introduza o nome da despesa")]
        public string NomeDespesa
        {
            get { return nomeDespesa; }
            set { nomeDespesa = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        [Required(ErrorMessage = "Introduza o valor")]
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [Required(ErrorMessage = "Introduza a categoria da despesa")]
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }
    }
}
