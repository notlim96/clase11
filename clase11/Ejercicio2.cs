using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11
{
    public class Ejercicio2
    {
        private List<int> lista = new List<int>();

        public int Elemento2 { get; set; }

        public void AgregarElemento()
        {
            lista.Add(Elemento2);
        }

        public void EliminarElemento()
        {
            try
            {
                lista.Remove(lista.Last());
                Console.WriteLine("Elemento Eliminado con Êxito ..... !!!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
