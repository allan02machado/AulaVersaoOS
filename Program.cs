using System;
using Figgle;

namespace AulaVersaoOS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeSO = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            string arquiteturaSO = System.Runtime.InteropServices.RuntimeInformation.OSArchitecture.
                ToString();            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Descubra qual o seu Sistema Operacional");
            Console.WriteLine("Pressione uma tecla para prosseguir...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(FiggleFonts.Big.Render($"{nomeSO}"));
            Console.WriteLine(FiggleFonts.Big.Render($"{arquiteturaSO}"));
            Console.ResetColor();
        }
    }
}
