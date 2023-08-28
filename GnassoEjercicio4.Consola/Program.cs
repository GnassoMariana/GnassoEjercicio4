using System;
using GnassoEjercicio4.Entidades;

namespace GnassoEjercicio4.Consola 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un peso en kilogramos:");
            float kilo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar un peso en libras:");
            float libra = float.Parse(Console.ReadLine());

           Kilogramo kilogramo = new Kilogramo(kilo);
           Libra libras = new Libra(libra);

            var Suma = kilogramo + libras;
            Console.WriteLine($"{Suma}");
            
        }
    }
}
