using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int r = rng.Next(1, 100);
            // Console.WriteLine(r);
            int notry = 1000;
            int nr;
            bool gameOver = false;

            Console.WriteLine("Type a number:");

            while (gameOver == false)
            {
                nr = Convert.ToInt32(Console.ReadLine());
                notry--;
                //if (nr != r)
                //{
                //    Console.WriteLine("Type a number!");
                //    gameOver = true;
                //}
                if (nr == r)

                {
                    Console.WriteLine("You guessed the number");
                    gameOver = true;
                }
                else if (nr > r)
                {
                    Console.WriteLine("Your number is to big!");
                    gameOver = false;

                }
                else if (nr < r)
                {
                    Console.WriteLine("Your number is to small!");
                    gameOver = false;
                }
            }
            Console.ReadLine();
        }
    }
}
