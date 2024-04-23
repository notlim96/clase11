using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11
{
    public class ManejadorLista
    {
        private List<int> lista = new List<int>();

        public void AgregarElemento(int elemento)
        {
            lista.Add(elemento);
        }

        public void EliminarElemento()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("La lista está vacía. No se puede eliminar ningún elemento.");
            }
            else
            {
                lista.RemoveAt(lista.Count - 1);
            }
        }
    }

    
}
