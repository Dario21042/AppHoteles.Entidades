using System.ComponentModel.DataAnnotations;

namespace AppHoteles.Entidades
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public string? Cliente  { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public double? Precio { get; set; }

        public List<Hotel>? HotelList { get; set; }

    }
}
