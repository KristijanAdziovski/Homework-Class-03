using System;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] studentGOne = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsGTwo = { "Zoki", "Mile", "Brus", "Petko", "Vele" };

            Console.WriteLine("Pleas input 1 or 2 to print students list");
            string list = Console.ReadLine();
            int numberList = int.Parse(list);
            switch (numberList)
            {
                case 1:

                    Console.WriteLine("The Students in G1 are: /n");

                    for ( int i = 0; i <studentGOne.Length; i++)
                    {
                        Console.Write("{0} \n ", studentGOne[i]);
                    }
                    break;
                case 2:
                    Console.WriteLine("The Students in G1 are: \n");

                    for ( int j = 0; j < studentsGTwo.Length; j++)
                    {
                       
                        Console.Write("{0} \n", studentsGTwo[j]);
                    }
                    break ;

                default:
                    Console.WriteLine("You don't input 1 or 2 ");
                    break ;
            }
        }
    }
}
