using System;
using System.ComponentModel.DataAnnotations;

namespace backend.models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MinLength(3, ErrorMessage = "Esse campo aceita de 3 a 60 caracteres")]
        [MaxLength(60, ErrorMessage = "Esse campo aceita de 3 a 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MinLength(1, ErrorMessage = "Esse campo aceita de 1 a 12 caracteres")]
        [MaxLength(12, ErrorMessage = "Esse campo aceita de 1 a 12 caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MinLength(3, ErrorMessage = "Esse campo aceita de 3 a 60 caracteres")]
        [MaxLength(60, ErrorMessage = "Esse campo aceita de 3 a 60 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        [MinLength(1, ErrorMessage = "Esse campo aceita de 1 a 16 caracteres")]
        [MaxLength(16, ErrorMessage = "Esse campo aceita de 1 a 16 caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigario")]
        public DateTime DataNascimento { get; set; }

    }
}