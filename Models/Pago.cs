using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRACTICA_1.Models
{
   public class Pago
    {
        public string numTarjeta { get; set; }
        public string FechaVencimiento { get; set; }
        public double montoPagar { get; set; }
        public int diasAtrasados { get; set; }
        public double mora { get; set; }
        public double Result { get; set; }
    }
}