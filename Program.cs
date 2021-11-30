using System;

namespace revision_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double año1, año2 ,año3 ,año4;
            double resta1, resta2, resultado;

            Console.WriteLine("Resolucion de edades\n");

            Console.Write("\nPrimer paso: coloque su nombre\n");

            Console.WriteLine("\nInserte su nombre aqui: \n");
            nombre = Console.ReadLine();

            Console.Clear();

            Console.Write("Segundo paso: introducir valores para ejecutar \n");

            Console.WriteLine("\nColoca el año actual: \n ");
             año1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nColoca el año de tu nacimiento: \n ");
            año2 = Convert.ToDouble(Console.ReadLine());

                resta1 = año1 - año2;

            Console.Clear();

            Console.Write("Tercer paso: volver a introducir valores para ejecutar \n");

            Console.WriteLine("\nColoca el año del cual quieres saber tu edad: \n ");
            año3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nColoca el año actual: \n ");
            año4 = Convert.ToDouble(Console.ReadLine());

            resta2 = año3 - año4;

            resultado = resta1 + resta2;

            Console.Clear();

            Console.Write("Cuarto paso: ¡¡disfrute del resultado!! \n\n");

            Console.WriteLine(nombre + " ,tu edad actual es: " + resta1 + "\n");
            Console.WriteLine(nombre + " ,la edad que quieres descubrir es: " + resultado + "\n");

            Console.Write("\n ¡¡Gracias por utilizar este programa :) !!");

            Console.ReadKey();

        }
    }
}
