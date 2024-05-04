using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public String   Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public String   Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        public Perfil   Perfil { get; set; }

    }
    public enum Perfil
    {
        Admim,
        User   
    }
}
