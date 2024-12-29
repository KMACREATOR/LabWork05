using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork05_Problem03
{
    public class Program
    {
        public static void Main()
        {
            var myDict = new MyDictionary<string, int>();

            myDict.Add("one", 1);
            myDict.Add("two", 2);
            myDict.Add("three", 3);

            Console.WriteLine("Количество элементов: " + myDict.Count);

            Console.WriteLine("Значение по ключу 'two': " + myDict["two"]);

            Console.WriteLine("Перебор элементов:");
            foreach (var pair in myDict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }

}
