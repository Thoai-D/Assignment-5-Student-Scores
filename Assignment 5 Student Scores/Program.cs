using System;

namespace Assignment_5_Student_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Student toy = new Student("Toy", 12, 1, 2, 3, 4, 5);
            Console.WriteLine(toy.Getaverage());
            Console.WriteLine(toy.Gethighest());
            Console.WriteLine(toy.Getlowest());
            Console.WriteLine(toy.Getallscores());
        }
    }
}
