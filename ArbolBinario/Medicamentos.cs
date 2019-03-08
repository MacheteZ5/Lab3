using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Medicamentos
    {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public string Descripción { get; set; }
            public double Precio { get; set; }
            public string CasaFarmaceutica { set; get; }
    }
}
