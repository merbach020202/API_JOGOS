using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório!")]
        public string Email { get; set; }


        [StringLength(20, MinimumLength = 2, ErrorMessage = "A senha deve ter de 2 a 20 caracteres ")]
        [Required(ErrorMessage = "O campo senha é obrigatório!")]
        public string Senha { get; set; }
    }
}

