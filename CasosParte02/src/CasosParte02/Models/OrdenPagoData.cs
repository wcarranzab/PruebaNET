using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasosParte02.Models
{
    public class OrdenPagoData
    {
        public int ordenPagoID { get; set; }
        public decimal monto { get; set; }
        public string estado { get; set; }
        public DateTime fechaPago { get; set; }
    }
}
