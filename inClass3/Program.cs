using System;

namespace inClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, please enter a number for a grade.");
            string input = Console.ReadLine();
            double grade = Double.Parse(input);
            

            bool cont = true;

            while (cont)
            {
                
                if (grade > 100)
                {
                    Console.WriteLine("WOW you got an A+ you smarty pants!");
                }
                else if (grade >= 90)
                {
                    Console.WriteLine("You got an A, good job!");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("You got an B, good work!");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("You got an C.");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("You got an D. :/ ");
                }
                else if (grade >= 0)
                {
                    Console.WriteLine("You got an F. :[ ");
                }
                else
                {
                    Console.WriteLine("You did not enter a proper number. Please try again");
                }
                

                
                Console.WriteLine("Please enter your name.");
                string name = Console.ReadLine();

                string hello = GreetUser(name);
                Console.WriteLine(hello);

                Console.WriteLine(GreetUser("Stan"));
                

                
                Console.WriteLine("Hello, please enter a language.");
                string input = Console.ReadLine();
                input = input.ToLower();

                Console.WriteLine("OK, I may be able to help you with that...let me check...");
                
                if (CheckLanguage(input))
                {
                    Console.WriteLine($"Yes, I can speak, {input}");
                }
                else
                {
                    Console.WriteLine($"Sorry, I cant help you with the language: {input}");
                }
                //Console.WriteLine(languageKnown);
                

                
                // CALL ReadIntegers
                int userNumber = ReadIntegers("How old are you?");
                if (userNumber >= 65)
                {
                    Console.WriteLine("You are old enough to retire");
                }
                else
                {
                    Console.WriteLine("Just keep working, and working, and working, and working");
                }

                int birthYear = ReadIntegers("What year were you born?");
                Console.WriteLine(birthYear);

                
                

                int num = ReadIntegers("Please enter a number for series math.");
                Console.WriteLine(CountNumbers(num));


                num = ReadIntegers("Please enter a number for a count down.");
                CountDownToBlastOff(num);
                
                cont = ContinueProgram(cont);

            }

            Console.WriteLine("Have a Terrific day! \n");

        }

        //Begin GreetUser Method
        public static string GreetUser(string name)
        {
            string greeting = $"Hi, {name}";
            return greeting;
        }

        //Begin CheckLanguage Method
        public static bool CheckLanguage(string computerLanguage)
        {
            //string langCheck = "";

            if (computerLanguage == "english" || computerLanguage == "spanish" || computerLanguage == "japanese")
            {
                //langCheck = $"Yes, I can speak, {computerLanguage}";
                return true;
            }
            else
            {
                //langCheck = $"Sorry, I cant help you with the language: {computerLanguage}";
                return false;
            }
        }

        public static bool ContinueProgram(bool cont)
        {
            Console.WriteLine("Would you like to continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();

            while (cont)
            {
                if (input[0] == 'y')
                {
                    cont = true;
                    break;
                }
                else if (input[0] == 'n')
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid input. Please enter y/n.");
                    input = Console.ReadLine();
                    input = input.ToLower();
                }
            }
            return cont;
        }

        //create a static method called ReadIntegers that
        //takes in a string message as a parameter
        //This method should use the parameter to prompt the user,
        //take in user input, convert the input into an integer, and return the number.

        public static int ReadIntegers(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number = int.Parse(input);

            return number;
        }

        public static int CountNumbers(int number)
        {
            int total = 0;

            for (int i = 1; i <= number; i++)
            {
                total += i;
            }
            return total;
        }

        public static void CountDownToBlastOff(int number)
        {
            for (int i = number; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("blast ooofffffffffffff!!");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
