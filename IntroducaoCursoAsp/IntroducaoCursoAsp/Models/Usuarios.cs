using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IntroducaoCursoAsp.Models
{
    public class Usuarios
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 50 caracteres")]
        public string Observações { get; set; }

        [Range(18, 60, ErrorMessage = "A idade precisa estar entre 18 e 60 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+", ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage ="Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage ="O login é obrigatório")]
        [Remote("LoginUnico","Usuarios",ErrorMessage ="Este login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage ="A senha é obrigatória")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha",ErrorMessage ="As senhas nao se coincidem")]
        public string ConfirmaSenha { get; set; }
    }
}