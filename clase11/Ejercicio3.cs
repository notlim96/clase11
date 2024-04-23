using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11
{
    public class Ejercicio3
    {
        public string Cadena { get; set; }
        public void ConvertirNumero()
        {
            try
            {
                int numCaden;
                Console.WriteLine("Ingrese la cadena");
                Cadena = Console.ReadLine();

                numCaden = int.Parse(Cadena);

                Console.WriteLine($"Si se convirtio la cadena a numero es: {numCaden}");   
            }catch (FormatException ex)
            {
                Console.WriteLine("El error es: " + ex);
            }
        }
    }
}
