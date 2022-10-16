using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUserText;
            int numberRepeats;

            Console.Write("Введите текст, который должен повторяться: ");
            inputUserText = Console.ReadLine();
            Console.Write("Сколько раз текст должен повториться: ");
            numberRepeats = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberRepeats; i++)
            {
                Console.WriteLine(inputUserText);
            }
            Console.ReadKey();
        }
    }
}
