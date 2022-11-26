using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Domain.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "O email é obrigatório para o login")]
        [EmailAddress(ErrorMessage ="Email em formato inválido")]
        [StringLength(100, ErrorMessage ="Email deve conter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
