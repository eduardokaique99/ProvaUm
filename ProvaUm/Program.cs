// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text;

namespace Prova1
{
    public class Prova 
    {
        public static void Main(String[] args) 
        {
            string[] lines = File.ReadAllLines("C:/Users/eduardo.furlaneto/OneDrive - SENAC-SC/DOTNET/Prova1/Prova1/naoordenado.txt", Encoding.UTF8);
            Console.WriteLine("\nArray de entrada");
            Array.ForEach(lines, item => { Console.WriteLine(item); });
        }
    }
}
