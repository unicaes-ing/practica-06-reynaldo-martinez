using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica09Reynadlo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Console.WriteLine("Coloque un ejercicio 1-4");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                   int num;
                   Console.WriteLine("Tabla de multiplicar");
                   #region LlamadaFuncion
                   Validacion.Validar("Ingrese el número que desea:", out num);
                   Ejercicio1.Tabla(num);
                   Console.WriteLine("Presione <Enter> para continuar...");
                   Console.ReadKey();
                   #endregion
                   Console.Clear();
                   Console.WriteLine("Ingrese el número que desea:");
                   Validacion.Validar("Ingrese el número que desea:", out num);
                   Ejercicio1.Tabla(num, ConsoleColor.Yellow);
                   Console.WriteLine("Presione <Enter> para continuar...");
                   Console.ReadKey();
                    break;
                case 2:
                    
            int ancho, alto, x, y;
            char caracter;
            #region Ancho
            Validacion.Validar("Ingrese el ancho del rectangulo: ", out ancho);
            #endregion
            #region Alto
            Validacion.Validar("Ingrese el alto del rectangulo: ", out alto);
            #endregion
            #region Llamada de funcion 1
            Ejercicio2.Dibujo(ancho, alto);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            // Llamada de la sobrecarga de la función
            Console.WriteLine("Ingrese el caracter deseado: ");
            caracter = char.Parse(Console.ReadLine());
            Ejercicio2.Dibujo(ancho, alto, caracter);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();
            Console.Clear();
            
            // CoordenadaX
            Validacion.Validar("Ingrese la coordenada X: ", out x);
            
            // CoordenadaY
            Validacion.Validar("Ingrese la coordenada Y: ", out y);
            
             //Llamada de la sobrecarga de la funciòn 2
            Console.Clear();
            Ejercicio2.Dibujo(ancho, alto, caracter, x, y);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();
                    break;
                case 3:
                 int bases = 0, exponente = 0;
             //Base
            Validacion.Validar("Ingrese la base: ", out bases);
            
             //Exponente
            Console.WriteLine();
            Validacion.Validar("Ingrese el exponente: ", out exponente);
            
            Console.WriteLine(Ejercicio3.NumElevado(2, 4));
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
                    break;
                case 4:
                    int n = 0;
            Console.WriteLine("Ingrese el numero");
            n = Convert.ToInt32(Console.ReadLine());
            Ejercicio4.DecimalaBinario(n);
            Console.WriteLine("\nPresione <Enter> para continuar...");
            Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}
