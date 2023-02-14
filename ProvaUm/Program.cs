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
            int[] arrayInt = lines.Select(Int32.Parse).ToArray();
            insertionSort(arrayInt);
            List<int> Colletion = arrayInt.ToList<int>(); 
        }

            public static void insertionSort(int[] arrayInt) { // Ordenação dos valores
            int j, key, i;
            Console.WriteLine("\nPassos para ordenação: ");
            for (j = 0; j < arrayInt.Length; j++) // for com o tamanho maximo do array
                {
                key = arrayInt[j];
                for (i = j - 1; (i >= 0) && (arrayInt[i] > key); i--)
                    {
                        arrayInt[i + 1] = arrayInt[i];
                    }
                arrayInt[i + 1] = key;
                Console.WriteLine("Passo " + j);
                foreach(var s in arrayInt)
                    {
                        Console.WriteLine(s);
                    }
	            }
            }
    }
}