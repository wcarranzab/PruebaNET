using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasosParte02.Models
{
    public class BancoData
    {
        public int bancoID { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }
    }
}
