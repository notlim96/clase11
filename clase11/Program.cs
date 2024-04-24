

using clase11;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        // creamos el MENU
        string opcionString;
        int opcion;
        bool salir = false;

        do
        {
            Console.WriteLine("********************************************************+***");
            Console.WriteLine("1) Ejercicio 1");
            Console.WriteLine("2) Ejercicio 2");
            Console.WriteLine("3) Ejercicio 3");
            Console.WriteLine("********************************************************+***");

            //   validamos que ingresado la opcio sea de tipo ENTERO
            Console.WriteLine("Seleccione una opcion:");
            opcionString = Console.ReadLine();
            bool isNumeric = int.TryParse(opcionString, out opcion);

            if (isNumeric)  // si es TRUE
            {
                switch (opcion)
                {
                    case 1:
                        bool salire1 = false;
                        do
                        {
                            try
                            {
                                int num1, num2;
                                Console.WriteLine("Ingrese el Numero  1:");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el Numero 2:");
                                num2 = Convert.ToInt32(Console.ReadLine());

                                Funcion ejeq1 = new Funcion
                                {
                                    Numero1 = num1,
                                    Numero2 = num2
                                };

                                // invovamos al metodo
                                ejeq1.Dividir();
                                salire1 = true;
                                salir = true;
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Hubo error al ingresar los numeros");
                            }
                        } while (!salire1);
                        break;
                    case 2:
                        Ejercicio2 manejador = new Ejercicio2();
                        // llenamos la lista de manera dinamica
                        string Salire2 = "";
                        int elemento2 = 0;
                        do
                        {
                            Console.WriteLine("*********** AGREGAR ELEMENTO  **********");
                            Console.WriteLine("Ingresar un  nuevo valor");
                            elemento2 = Convert.ToInt32(Console.ReadLine());

                            manejador.Elemento2 = elemento2;
                            manejador.AgregarElemento();

                            Console.WriteLine("¿Deseas Salir, Escriba(SI/NO)?");
                            Salire2 = Console.ReadLine();

                        } while (Salire2.ToUpper() != "SI");
                        // eliminamos elementos de la list
                        string Salire3 = "";
                        do
                        {
                            Console.WriteLine("*********** ELIMINAR ELEMENTO  **********");
                            manejador.EliminarElemento();
                            Console.WriteLine("¿Desea seguir eliminando un elemento, Escriba(SI/NO)?");
                            Salire3 = Console.ReadLine();
            
                        } while (Salire3.ToUpper() != "NO");
                        salir = true;
                        break;
                    case 3:
                        Ejercicio3 ejer3 = new Ejercicio3();
                        ejer3.ConvertirNumero();
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion  no valida solo se acepta opciones (1),(2),(3)");
                        break;
                }
            }
            else  //  si es FALSE
            {
                Console.WriteLine("Opcion invalida");
            }
        } while (!salir);
    }
}

