using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variables for user answer (in string form), user input (converted to int32), and total.
            int userInput= -1;
            int userTotal = 0;
            string userInitial;
            //prints out question and reads answer for the first time
            Console.WriteLine("Please input a number and I will add it to your total.");
            Console.WriteLine("If finished, please enter E or e."); 
            userInitial = Console.ReadLine();
            //if user doesn't input e/E, then while loop adds the input number to total
            while (userInitial != "e" && userInitial != "E")//had the most trouble with this spot when it had ||, so with help, 
                //I figured out that it was supposed to be &&, otherwise the loop would keep running forever (my own stupid mistake).
            {
                userInput = Convert.ToInt32(userInitial);
                userTotal = userTotal + userInput;
                //write question and read input again for the 2nd, 3rd, etc. time
                Console.WriteLine("Please input a number and I will add it to your total. If finished, please enter E or e.");
                userInitial = Console.ReadLine();
            }
            //tell user the total
            Console.WriteLine("Your total is: {0}", userTotal);
            Console.ReadLine();
        }
    }
}
