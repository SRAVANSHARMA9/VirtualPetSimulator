using System;
using System.ComponentModel.Design;
namespace Ass1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose a type of pet");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            Console.WriteLine("");

            Console.WriteLine("User input is :");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1)
            {
                Console.WriteLine("You have selected Cat. What would you like to name your Cat as?");
            }
            else if (userinput == 2)
            {
                Console.WriteLine("You have selected Dog. What would you like to name your Dog as?");
            }
            else if (userinput == 3)
            {
                Console.WriteLine("You have selected Rabbit. What would you like to name your Rabbit as?");
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2 or 3 as input. Other values are not accepted as input");
                return;
            }


            Console.WriteLine("");


            Console.WriteLine("User input is : ");

            String PetName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Welcome, " + PetName + ". Lets take good care of you.");

            Console.WriteLine("");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("");
            Console.WriteLine("1. Feed " + PetName);
            Console.WriteLine("2. Play with " + PetName);
            Console.WriteLine("3. Let " + PetName + " Rest");
            Console.WriteLine("4. Check " + PetName + "'s Status");
            Console.WriteLine("5. Exit ");


            Console.WriteLine("");

            
            Console.WriteLine("User input is : ");
            int statsinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1)
            {

                Console.WriteLine("has been " + PetName);
            }



        }
    }
}