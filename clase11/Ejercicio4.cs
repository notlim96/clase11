using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Ejercicio4
    {
        // Creacion del arreglo en  priuvado
        private int[] arreglo = new int[3];
        
        public void ObtenerElemento(int Indice)
        {
            // llenamos el arreglo
            arreglo[0] = 10;
            arreglo[1] = 11;
            arreglo[2] = 5;

            // hacemos el TRY-CATCH
            try
            {
                Console.WriteLine("Dato del Indice: " + arreglo[Indice]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Indice fuera de rango,Error: " + ex);
            }
        }
    }
}
