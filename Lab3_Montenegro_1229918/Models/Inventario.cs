using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_Montenegro_1229918.Models
{
    public class Inventario
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string descripción { get; set; }
        public string casaproductora { get; set; }
        public string precio { get; set; }
        public int existencia { get; set; }
    }
}