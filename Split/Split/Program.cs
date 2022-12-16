using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToWrite = "";

            Console.WriteLine("Введите предложение для переноса по строкам");
            stringToWrite = Console.ReadLine();
            string[] words = stringToWrite.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
