using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFiles
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"E:\input.txt");
            string[,] num = new string[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    num[i, j] = temp[j];
            }

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.WriteLine(num[i, j]);
                }
                Console.WriteLine();
            }
        
            
            Console.ReadKey();
        }
        
    }
}
