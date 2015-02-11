using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuickTests
{
    class Program
    {

        static void Main(string[] args)
        {

            var elementsSortedFile = "../../FileToCheck.txt";

            var listaAux = File.ReadAllLines(elementsSortedFile).ToList();

            if(ValuesAreRepetead(listaAux))
                Console.WriteLine("Hay algunos repetidos");
            else
            {
                Console.WriteLine("No hay valores repetidos");
            }
            
            Console.ReadLine();
        }

        public static bool ValuesAreRepetead(List<string> list )
        {
            var result = false;

            for (var i = 0; i < list.Count; i++)
            {
                for (var j=0;j<list.Count;j++)
                {
                    if (list[j].Equals(list[i]) && j!=i)
                    {
                        Console.WriteLine(list[j]);
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
