using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Deliverable10
{
    class Program
    {
        public class Square
        {
            public int size { get; set; }
            public Square(int size)
            {
                this.size = size;
            }
            
        }

        public static int Largest(List <Square> largestSquare)
        {
            var max = largestSquare.Max(s => s.size);

            return max;
        }

        public static int Smallest(List <Square> smallestSquare)
        {
            var min = smallestSquare.Min(s => s.size);
            return min;
        }
        public static double averageArea(List<Square> averageAreaSquare)
        {
          
       

        public static int averagePerimeter(List<Square> averagePerimeterSquare)
        {
            
        }

        public static void Main(string[] args)
        {
            List <Square> squares = new List<Square>();
            int userNumberInput = 0;
            bool userContinue = true;

            while (userContinue == true)
            {
                Console.Write("Enter a side length (q to quit): ");

                if (int.TryParse(Console.ReadLine(), out userNumberInput))
                {
                    Square s = new Square(userNumberInput);
                    squares.Add(s);

                    foreach (Square c in squares)
                    {
                        Console.WriteLine(c.size);
                    }
                }

                else  
                {
                    
                    Console.WriteLine(Largest(squares));
                    Console.WriteLine(Smallest(squares));
                    Console.WriteLine(averageArea(squares));

                }

                //else
                //{
                //    Console.WriteLine("That is not a valid input.");
                //}

                

                
                
            }
        }
    }
}
