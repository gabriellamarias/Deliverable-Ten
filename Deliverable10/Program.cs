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

        public static int squareCount(List<Square> countSquare)
        {
            var count = countSquare.Count();

            return count;
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
            List<int> intSquare = new List<int>();

            foreach (Square s in averageAreaSquare)
            {
                int i = s.size * s.size;

                intSquare.Add(i);
            }

            return intSquare.Average();
        }


        public static double averagePerimeter(List<Square> averagePerimeterSquare)
        {
            List<int> intSquare = new List<int>();

            foreach (Square s in averagePerimeterSquare)
            {
                int i = s.size * 4;

                intSquare.Add(i);
            }

            return intSquare.Average();
        }

        public static void Main(string[] args)
        {
            List <Square> squares = new List<Square>();
            int userNumberInput = 0;
            string userInputContinue = "";
            bool userContinue = true;
            

            while (userContinue == true)
            {
                Console.Write("Enter a side length (q to quit): ");

                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userNumberInput))
                {
                    Square s = new Square(userNumberInput);
                    squares.Add(s);
                }

                else if (userInput == "q")
                {
                    Console.WriteLine($"You created {squareCount(squares)} squares.");
                    Console.WriteLine($"Largest: {Largest(squares)}");
                    Console.WriteLine($"Smallest: {Smallest(squares)}");
                    Console.WriteLine($"Average Area: {averageArea(squares)}");
                    Console.WriteLine($"Average Perimeter: {averagePerimeter(squares)}");
                    Console.Write("Do you wish to continue (y/n)? ");

                    userInputContinue = Console.ReadLine();
                    if (userInputContinue == "n")
                    {
                        userContinue = false;
                        Console.WriteLine("Goodbye!");
                    }

                    squares.Clear();

                }

                //else
                //{
                //    Console.WriteLine("That is not a valid input.");
                //}

                

                
                
            }
        }
    }
}
