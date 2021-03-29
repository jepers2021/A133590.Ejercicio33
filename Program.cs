using System;

namespace A133590.Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 33.");
            Console.WriteLine("Programa que presenta la diferencia entre una fecha hasta el fin de año más cercano");
            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("La fecha ingresada no es válida.");
                return;
            }


            DateTime otraFecha = new DateTime(fecha.Year, 12, 31);

            TimeSpan diferencia = fecha - otraFecha;
            int dias = Math.Abs((int)diferencia.TotalDays);
            DateTime auxiliar = DateTime.MinValue;
            auxiliar = auxiliar.AddDays(dias);


            Console.WriteLine("Diferencia:");
            Console.WriteLine($"Años: {auxiliar.Year - 1}");
            Console.WriteLine($"Meses: {auxiliar.Month - 1}");
            Console.WriteLine($"Días: {auxiliar.Day - 1}");



            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
