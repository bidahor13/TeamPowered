using System;


//My project 
class Program
{
    static void Main()
    {
        double runningTotal = 0;
        bool keepGoing = true;
        //Prompts the user for data entry

        while (keepGoing)
        {
            System.Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

            //Reads the users input
            string entry = Console.ReadLine();

            if (entry.ToLower() == "quit")
            {
                keepGoing = false;
            }
            else {

                //Deals with the System.FormatException in case a string value is placed as an input value.
                try
                {
                    double minutes = int.Parse(entry);
                    if (minutes <= 0)
                    {
                        Console.WriteLine("The value " + minutes + " Minutes is not an acceptable value.");
                        continue;
                    }

                    if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!! ");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training");
                    }
                    else
                    {
                        Console.WriteLine("ok!now you are just showing off!");
                    }

                    //Add minutes exercised as a total
                    runningTotal += minutes;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("This is not a valid input entry");
                    continue;
                }

                //Display total minutes exercised to the screen
                Console.Write("You have entered: " + runningTotal + " minutes" + "\n");

            }
            //Console.WriteLine("Your FINAL DATA: " + runningTotal + " minutes" );
            //Console.WriteLine("Goodbye!"); 
        }

        Console.WriteLine("Your FINAL DATA: " + runningTotal + " minutes");
        Console.WriteLine("Goodbye!");

    }
}



