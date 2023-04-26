using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace LABCOMPRAS22.Models
{
    public class ContasBancarias
    {
        [Required (ErrorMessage = "É obrigatorio o preenchimento deste campo")]
        public string NomeTitular { get; set; }

        [Required  (ErrorMessage = "É obrigatorio o preenchimento deste campo")]
        public int Saldo { get; set; }
       
        public bool Ativa { get; set; }
        


    }
}

    

