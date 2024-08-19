using System;


namespace Basic_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }

                Console.WriteLine(sum);

                Console.Write("Would you like to continue (y/n)? ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                {
                    continueProgram = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
    

