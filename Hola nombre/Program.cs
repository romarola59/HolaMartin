using System;

namespace Hola_nombre
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            /*crear un programa que te pida el nombre al usuario y si es 
             * martin le diga hola Martin , si no que le diga no te conozco.*/
            string usuario = "Martin",usuario1;

            Console.WriteLine("Ingrese su nombre de usuario: ");
            usuario1 = Console.ReadLine();
            if (usuario == usuario1)
            {
                Console.WriteLine("Hola Martin");
            }
            else
            {
                Console.WriteLine(" Oyeeee ..No te conozco!!!!!!!{0}",usuario1);
            }
            Console.ReadKey();
            





        }
    }
}
