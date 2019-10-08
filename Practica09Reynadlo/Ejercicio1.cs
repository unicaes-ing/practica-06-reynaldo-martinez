using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica09Reynadlo
{
    public class Validacion
    {
        public static void Validar(string mensaje, out int num)
        {
            bool condicion;
            do
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                condicion = int.TryParse(Console.ReadLine(), out num);
                if (condicion == false || num < 0)
                {
                    Console.WriteLine("Valor no válido. Introduzca nuevamente un valor.");
                    Console.WriteLine("Presione <Enter> para continuar...");
                    Console.ReadKey();
                }
            } while (condicion == false || num < 0);
        }

        public static void Validar(string mensaje, double num = 0)
        {
            bool condicion;
            do
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                condicion = double.TryParse(Console.ReadLine(), out num);
                if (condicion == false || num < 0)
                {
                    Console.WriteLine("Valor no válido. Introduzca nuevamente un valor.");
                    Console.WriteLine("Presione <Enter> para continuar...");
                    Console.ReadKey();
                }
            } while (condicion == false || num < 0);
        }

    }


    public class Ejercicio1 : Validacion
    {
        public static void Tabla(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        }


        // Funcion2
        public static void Tabla(int num, ConsoleColor color)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        }

    }

    public class Ejercicio2 : Validacion
    {
       


        #region Funcion1
        public static void Dibujo(int alto, int ancho)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine(" ");
                Console.Write(" ");
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
            }
        }
        #endregion

        #region Sobrecarga1
       public static void Dibujo(int alto, int ancho, char caracter)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine(" ");
                Console.Write(" ");
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write(caracter);
                    Console.Write(" ");
                }
            }
        }
        #endregion

        #region Sobrecarga2
        public static void Dibujo(int alto, int ancho, char caracter, int x, int y)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine(" ");
                Console.Write(" ");
                Console.SetCursorPosition(x, y++);
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write(caracter);
                    Console.Write(" ");
                }
            }
        }
        #endregion
    }

    public class Ejercicio3 : Validacion
    {
        

        #region Funcion
        public static int NumElevado(int bases, int exponente)
        {
            if (exponente < 1)
            {
                return 1;
            }
            return bases * NumElevado(bases, exponente - 1);
        }
        #endregion
    }

    public class Ejercicio4
    {
        

        public static void DecimalaBinario(int num)
        {
            if (num < 2)
            {
                Console.Write(num);
            }
            else
            {
                DecimalaBinario(num / 2);
                Console.Write(num % 2);
            }
        }
    }


}

