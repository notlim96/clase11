using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Ejercicio5
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public void VerificarNegativo()
        {
            try
            {
                if(Numero2 == 0)
                {
                    throw new DivideByZeroException("No se  puede DIVIDIR entre 0");
                }
                if(Numero1 <0  || Numero2 < 0)
                {
                    throw new ArgumentException("Los  numero deben de ser POSITIVOS");
                }

                Console.WriteLine("La DIVISION es: " + (Numero1/Numero2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingese un numero valido ");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("El error es: " + ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("El error es: " + ex);
            }
        }
    }
}
