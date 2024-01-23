using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Clasetipodatos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //tipos de datos primitos

            int num1, num3, num4;  // enteras permiten numeros positivos y negativos
            int num2;
            byte b = 25;
            long l = -25;

            double doble = 3.66666666666614d;  // numero con decimales
            float flotante = 56.34f;  // numero con decimales
            Decimal dec = 15.78m;

            string nombre = "Carlos";   // cadena de caracteres
            string apellido = "Perez";
            char caracter = 'A';

            Boolean boleano = false;

            var variable = true;

            dynamic dinamica = 20;
            dinamica = true;
            dinamica = "Hola mundo";
            dinamica = 'A';

            num1 = 10;
            num2 = 5;

            //Console.WriteLine("Digite un numero:");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite otro numero");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Multiplicacion:" + num2 * num2);
            //Console.WriteLine("suma: " + num1 + "+" + num2 + " = " + (num2 + num1)); // concatenacion
            //Console.WriteLine("Multiplicacion: {0} * {1} = {2}", num2, num1, (num1 * num2)); //referencia
            //Console.WriteLine($"Resta: {num1} - {num2} = {(num1-num2)}"); //interpolacion

            Console.WriteLine("digite el nombre del dia");
            string dia = Console.ReadLine();
            if (dia.Equals("lunes"))
            {
                Console.WriteLine("dia 1");
            } else
           
            if (dia.Equals("Martes"))
            {
                Console.WriteLine("dia 2");
            }
             else
            if (dia.Equals("Miercoles"))
            {
                Console.WriteLine("dia 3");
            } else
          
            if(!dia.Equals("Lunes") || dia.Equals("Martes") || !dia.Equals("Miercoles"))
            {
                Console.WriteLine("No es un dia de la semana");
            }

            // string toupper, tolower 


            //switch (dia)
            //{
            //    case "Lunes":
            //        Console.WriteLine("dia 1"); ;
            //        break;
            //    case "Martes":
            //        Console.WriteLine("dia 2");
            //        break;
            //    case "Miercoles":
            //        Console.WriteLine("dia 3");
            //        break;
            //    default: Console.WriteLine("No es un dia de la semana");
            //        break;



            //}




            // condiciones

            if (num1>num2) 
            {
                Console.WriteLine($"num1 es mayor que num2");
            } else if (num1<num2)
            {
                Console.WriteLine($"num1 es menor que num2");
            }
            else if (num1==num2)
            {
                Console.WriteLine($"num1 es igual que num2");
            }
           


            Console.Read();
        }
    }
}

