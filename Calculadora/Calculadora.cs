using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculadora
    {
        string mensaje = "";
        public Calculadora(string mensaje2)
        {
            mensaje = mensaje2;
        }
        public void Start()
        {
            bool salir = false;
            do
            {

                Console.WriteLine(mensaje);
                string operacion = Console.ReadLine();
                Console.WriteLine("Digite el primer sumando: ");
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite el segundo sumando: ");
                var b = double.Parse(Console.ReadLine());

                switch (operacion)
                {
                    case "+":
                        Suma(a, b);
                        break;

                    case "-":
                        Resta();
                        break;

                    case "*":
                        Multiplicacion();
                        break;

                    case "/":
                        Division();
                        break;

                    case "salir":
                        salir = true;
                        break;


                }

            }
            while (salir != true);

           



        }

        public static void Suma(double a, double b)
        {
            var sumatoria = (double)a + (double)b;

            Console.WriteLine("El resultado de la operacion es: {0} ", sumatoria);

        }

        public static double Resta()
        {
            Console.WriteLine("Digite el primer digito a restar: ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo digito a restar: ");
            var b = double.Parse(Console.ReadLine());

            var resta = (double)a - (double)b;

            Console.WriteLine("El resultado de la operacion es: {0} ", resta);

            return resta;
        }

        public static double Multiplicacion()
        {
            Console.WriteLine("Digite el primer digito a multiplicar: ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo digito a multiplicar: ");
            var b = double.Parse(Console.ReadLine());

            var multiplicacion = (double)a * (double)b;

            Console.WriteLine("El resultado de la operacion es: {0} ", multiplicacion);

            return multiplicacion;
        }

        public static double Division()
        {
            Console.WriteLine("Digite el primer digito a dividir: ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo digito a dividir: ");
            var b = double.Parse(Console.ReadLine());

            var division = (double)a / (double)b;

            Console.WriteLine("El resultado de la operacion es: {0} ", division);

            return division;
        }
    }
}
