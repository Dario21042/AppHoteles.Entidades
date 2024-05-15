using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHoteles.Entidades
{
    public class Hotel
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }

        public int ReservaId { get; set; }
        public Reserva? Reserva { get; set; }

    }
}
