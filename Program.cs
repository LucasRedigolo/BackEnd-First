using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Qual capsula você quer?");
            string capsula = Console.ReadLine();
            string xicara = FazerCafe(capsula);
            System.Console.WriteLine("tomei " + xicara);
        }
        static string FazerCafe(string capsula)

        { 
            
            System.Console.WriteLine ("Esquentar agua");
            System.Console.WriteLine ("colocar pó da magia (café)");
            System.Console.WriteLine ("colocar " + capsula);
            return "cafe com " + capsula;
       
        }

    }
}
