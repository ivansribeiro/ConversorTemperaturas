using System;

namespace Exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius");

            string celsius = Console.ReadLine();
            double vCelsius= Convert.ToDouble(celsius);

            Console.WriteLine(string.Format("{0} Graus Celsius, equivalem a {1} Graus na escala Fahrenheit", celsius, CoverteToFahrenheit(vCelsius)));

            Console.WriteLine("Digite a temperatura em Fahrenheit");
            string fahrenheit = Console.ReadLine();
            double vfahrenheit = Convert.ToDouble(fahrenheit);

            Console.WriteLine(string.Format("{0} Graus Fahrenheit, equivalem a {1} Graus na escala Celsius", fahrenheit, CoverteToCelsius(vCelsius)));

        }

        private static double CoverteToCelsius(double valCelsius)
        {
            double resultado = valCelsius * 100;
            return resultado;
        }

        private static double CoverteToFahrenheit(double valFahrenheit)
        {
            double resultado = valFahrenheit * 212;
            return resultado;
        }

    }
}
