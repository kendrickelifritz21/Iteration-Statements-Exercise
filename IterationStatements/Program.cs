namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void PrintNumbersDecreasing()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            };
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void PrintNumbersIncrementingByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            };
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static void CheckIfIntegersAreEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }
        
        //Write a method to check whether a given number is even or odd
        static void CheckIfNumberIsEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        static void CheckIfNumberIsPositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static void CheckIfUserCanVote()
        {
            Console.WriteLine("Enter your age: ");
            var input = Console.ReadLine();
            int age;
            int.TryParse(input, out age);

            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You cannot vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void CheckIfNumberIsInRange()
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            int num;
            int.TryParse(input, out num);

            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("The number is in the range -10 to 10");
            }
            else
            {
                Console.WriteLine("The number is not in the range -10 to 10");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void DisplayMultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbersDecreasing();
            PrintNumbersIncrementingByThree();
            CheckIfIntegersAreEqual(5, 5);
            CheckIfNumberIsEvenOrOdd(5);
            CheckIfNumberIsPositiveOrNegative(5);
            CheckIfUserCanVote();
            CheckIfNumberIsInRange();
            DisplayMultiplicationTable(5);
        }
    }
}
