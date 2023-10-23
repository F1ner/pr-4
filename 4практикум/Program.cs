using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4практикум
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тест(компьютерный практикум №4):
            //1.1)

            //Console.WriteLine("Введите строку содержающую символ y:");
            //string str = Console.ReadLine();
            //char find = 'y';
            //char ins = 'x';
            //StringBuilder res = new StringBuilder();
            //foreach(char c in str)
            //{
            //    res.Append(c);
            //    if(c==find)
            //    {
            //        res.Append(ins);
            //    }

            //}
            //string str2 = res.ToString();
            //Console.WriteLine(str2);

            //2.1)
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            int n = 5;
            string[] words = str.Split(' ');
            int i = 1;
            foreach (string word in words)
            {
                if (word.Length <= n)
                {
                    Console.WriteLine($"{i++}){word}");
                }
            }

            Console.ReadKey();
        }
    }
}
