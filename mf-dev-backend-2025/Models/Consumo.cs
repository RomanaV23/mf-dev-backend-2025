using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int Km { get; set; }

        [Display(Name = "Tipo de combustível")]
        public TipoCombustível Tipo { get; set; }

        [Display(Name = "Veículo")]

        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        public int   VeículoId { get; set; }

        [ForeignKey("VeículoId")]
        public Veiculo Veículo { get; set; }
    }
    public enum TipoCombustível
    {
        Gasolina,
         Etanol
    }
}

