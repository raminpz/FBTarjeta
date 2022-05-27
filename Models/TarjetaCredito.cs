using System.ComponentModel.DataAnnotations;





namespace FBTarjeta.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }

        [Required]
        public string Titular { get; set; }
        [Required]
        public int NumeroTarjeta { get; set; }
        [Required]
        public int FechaExpiracion { get; set; }
        [Required]
        public int CVV { get; set; }
    }
}
