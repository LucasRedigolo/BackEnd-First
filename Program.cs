using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            FazerCafe("caramelo");
            FazerCafe("chocolate");
        }
        static void FazerCafe(string capsula)

        { 
            
            System.Console.WriteLine ("Esquentar agua");
            System.Console.WriteLine ("colocar pó da magia (café)");
            System.Console.WriteLine ("colocar " + capsula);

        }
    }
}
