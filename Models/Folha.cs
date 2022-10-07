using System;
using System.ComponentModel.DataAnnotations;
using API_Folhas.Validations;

namespace API_Folhas.Models
{
    public class Folha
    {
        //Data Annotations
        public Folha() => CriadoEm = DateTime.Now;
        public int FolhaId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo valor/hora é obrigatório!")]
        public int ValorHora { get; set; }

        [Required(ErrorMessage = "O campo Quantidade/Hora é obrigatório!")]
        public int QuantidadeHora { get; set; }

        [Required(ErrorMessage = "O campo Salário Bruto é obrigatório!")]
        public float SalarioBruto { get; set; }


        [Required(ErrorMessage = "O campo Imposto de renda é obrigatório!")]
        public float ImpostoRenda { get; set; }

        [Required(ErrorMessage = "O campo Imposto inss é obrigatório!")]
        public float Impostoinss { get; set; }

        [Required(ErrorMessage = "O campo Imposto FGTS é obrigatório!")]
        public float Impostofgts { get; set; }

        [Required(ErrorMessage = "O campo Salário Líquido é obrigatório!")]
        public float SalarioLiquido { get; set; }


        [Required(ErrorMessage = "O campo cpf é obrigatório!")]
        [StringLength(
            11, //Máximo de caracteres
            MinimumLength = 11,
            ErrorMessage = "O cpf deve conter 11 caracteres!"
        )]
        [CpfEmUso]
        public string Cpf { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }

        [Range(
            0,
            1000,
            ErrorMessage = "O salário deve ser até R$ 1.000,00"
        )]
        public int Salario { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }

        // public override string ToString()
        // {
        //     return base.ToString();
        // }
    }
}