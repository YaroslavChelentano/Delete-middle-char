using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24var
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                
                if(words[i].Length%2!=0)
                {
                    int middleOfNumber = 0;
                    middleOfNumber = (words[i].Length / 2);
                    words[i]=words[i].Remove(middleOfNumber, 1 );

                }
                Console.Write(words[i] + " " );


            }
            Console.WriteLine();
        }
    }
}
