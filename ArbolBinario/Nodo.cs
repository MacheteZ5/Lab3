using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public struct Medicamento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Descripción { get; set; }
        public double Precio { get; set; }
        public string CasaFarmaceutica { set; get; }
    }
    class Nodo
    {
       public Medicamento elemento;
       public Nodo izquierda, derecha;
    }
    //public string dato;

    //public Nodo hijo;
    //public Nodo hermano;

    //public string Dato { get => dato; set => dato = value; }
    //public Nodo Hijo { get => hijo; set => hijo = value; }
    //public Nodo Hermano { get => hermano;set=>hermano=value }

    //public Nodo()
    //{
    //    dato = "";
    //    hijo = null;
    //    hermano = null;
    //}

    //public Medicamentos Medicamento { get; set; }
    //public Nodo Padre { get; set; }
    //public Nodo Izquierdo { get; set; }
    //public Nodo Derecho { get; set; }

    //public Nodo(Medicamentos medicamento)
    //{
    //    this.Medicamento = medicamento;
    //}
    //public Nodo(Medicamentos medicamento, Nodo izquierdo, Nodo Derecho, Nodo padre)
    //{
    //    this.Medicamento = medicamento;
    //    this.Izquierdo = izquierdo;
    //    this.Derecho = Derecho;
    //    this.Padre = padre;
    //}
    //public bool EsRaiz()
    //{
    //    if (Padre != null)
    //    {
    //        return false;
    //    }
    //    else
    //    {
    //        return true;
    //    }
    //}
    //public bool ExisteIzquierdo()
    //{
    //    if (Izquierdo != null)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //public bool ExisteDerecho()
    //{
    //    if (Derecho != null)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //public bool TieneMedicamento()
    //{
    //    if (Medicamento != null)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

}

