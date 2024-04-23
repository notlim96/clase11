using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11
{
    public abstract class Ejercicio1
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public abstract void Dividir();
    }

    public class Funcion : Ejercicio1
    {
        public override void Dividir()
        {
            try
            {
                double result;
                result = Numero1 / Numero2;
                Console.WriteLine($"LA DIVISION es: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"La Dvision entre  0, no esta permitida: {ex.Message}");
            }
        }
    }
}
