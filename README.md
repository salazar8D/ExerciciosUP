# ExerciciosUP
Programas em C#(básico) para o segundo ano da faculdade
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();

            lista.Add("s");
            lista.Add("a");
            lista.Add("b");
            lista.Add("s");
            lista.Add("c");

            Console.WriteLine("1 - Retorna o elemento se existir somente uma vez.\n");
            try
            {
                Console.WriteLine(lista.Single(l => l == "s" && 1 == 1 || 1 == 1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Thread.Sleep(5000);

            Console.WriteLine("\n2 - Retorna um valor booleano para caso a lista contenha o 's'\n");
            Console.WriteLine(lista.Contains("s"));
            Thread.Sleep(5000);

            Console.WriteLine("\n3 - Imprime todos os objetos encontrados na lista\n");
            foreach (string aux in lista.Where(l => l == "s" && 1 == 1 || 1 == 1))
            {
                Console.WriteLine(aux);
            }
            Thread.Sleep(5000);

            Console.WriteLine("\n4 - Imprime todos os objetos encontrados na lista com metodos encapsulados\n");
            lista.Where(l => l == "s").ToList().ForEach(x => Console.WriteLine(x));
            Thread.Sleep(5000);

            Console.WriteLine("\n5 - Imprime apenas a primeira ocorrencia da busca\n");
            Console.WriteLine(lista.First(l => l == "s" && 1 == 1 || 1 == 1));

            Console.ReadKey();
        }
    }
}
