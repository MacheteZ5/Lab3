using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class arbol
    {
        Nodo raiz;
        public arbol()
        {
            raiz = null;
        }
        public void insertarNodo(string[] recibe)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            //se elimina el signo $ para tener unicamente el valor numérico
            if (recibe[4].Contains("$"))
            {
                recibe[4] = recibe[4].Trim(new Char[] { '$' });
            }
            nuevo.elemento.ID = Convert.ToInt16(recibe[0]);
            nuevo.elemento.Nombre = recibe[1];
            nuevo.elemento.Descripción = recibe[2];
            nuevo.elemento.CasaFarmaceutica = recibe[3];
            nuevo.elemento.Precio = Convert.ToDouble(recibe[4]);
            nuevo.elemento.Cantidad = Convert.ToInt16(recibe[5]);
            nuevo.izquierda = null;
            nuevo.derecha = null;

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                Nodo anterior = null;
                Nodo recorrer = raiz;
                while (recorrer != null)
                {
                    anterior = recorrer;
                    if (nuevo.elemento.Precio < recorrer.elemento.Precio)
                    {
                        recorrer = recorrer.izquierda;
                    }
                    else
                    {
                        recorrer = recorrer.derecha;
                    }
                    if (nuevo.elemento.Precio < anterior.elemento.Precio)
                    {
                        anterior.izquierda = nuevo;
                    }
                    else
                    {
                        anterior.derecha = nuevo;
                    }
                }
            }
        }

        private void PreOrden(Nodo recorrer)
        {
            if (recorrer != null)
            {
                Console.Write(recorrer.elemento.Nombre + " ");
                PreOrden(recorrer.izquierda);
                PreOrden(recorrer.derecha);
            }
        }
        private void InOrden(Nodo recorrer)
        {
            if (recorrer != null)
            {
                InOrden(recorrer.izquierda);
                Console.Write(recorrer.elemento.Nombre + " ");
                InOrden(recorrer.derecha);
            }
        }
        private void PostOrden(Nodo recorrer)
        {
            if (recorrer != null)
            {
                PostOrden(recorrer.izquierda);
                PostOrden(recorrer.derecha);
                Console.Write(recorrer.elemento.Nombre + " ");
            }
        }
        public void MostrarpreOrden()
        {
            PreOrden(raiz);
        }
        public void MostrarinOrden()
        {
            InOrden(raiz);
        }
        public void MostrarpostOrden()
        {
            PostOrden(raiz);
        }


        //public static List<NodoGenerico<T>> CreateGenericTree<T>(List<T> flatDataObject, Func<T, bool> IsRootNode) where T : IDbEntityNode
        //{
        //    var lookup = new Dictionary<int, NodoGenerico<T>>();
        //    var rootNodes = new List<NodoGenerico<T>>();
        //    var noOfElements = flatDataObject.Count;
        //    for (int element = 0; element < noOfElements; element++)
        //    {
        //        NodoGenerico<T> currentNode;
        //        if (lookup.TryGetValue(flatDataObject[element].ID, out currentNode))
        //        {
        //            currentNode.NodeInformation = flatDataObject[element];
        //        }
        //        else
        //        {
        //            currentNode = new GenericNode<T>() { NodeInformation = flatDataObject[element] };
        //            lookup.Add(flatDataObject[element].Id, currentNode);
        //        }

        //        if (IsRootNode(flatDataObject[element]))
        //        {
        //            rootNodes.Add(currentNode);
        //        }
        //        else
        //        {
        //            GenericNode<T> parentNode;
        //            if (!lookup.TryGetValue(flatDataObject[element].ParentId, out parentNode))
        //            {
        //                parentNode = new GenericNode<T>();
        //                lookup.Add(flatDataObject[element].ParentId, parentNode);
        //            }
        //            parentNode.Children.Add(currentNode);
        //            currentNode.Parent = parentNode;
        //        }
        //    }

        //    return rootNodes;
        //}

    }
}
