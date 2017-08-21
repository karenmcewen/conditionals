using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1 conditionals if/else/else if
            /*
             * Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if(age>=17)
            {//this will print if the condition is true
                Console.WriteLine("You can see the movie");
            }
            if (age == 18)
            {//another if statement for the computer to check
                Console.WriteLine("You are now an adult!");
            }

            else if (age == 21)
            {
                Console.WriteLine("Let's get a drink!");
            }

            else
            {//else command - this will print if the condition is false
                Console.WriteLine("Sorry, you need a parent present.");

            }
         
            // example of grades
            Console.WriteLine("Enter your percentage:");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("You got an A!");
            }
            else if (grade >= 80 && grade <=89)
            {
                Console.WriteLine("You got a B");
            }

            else
            {
                Console.WriteLine("I'm sorry, you need to try again");
            }

       */
            //Example 3 PROBLEM: At a restaurant, Mike and his three friends decided to divide the bill evenly. 
            //If each person paid $13 then what was the total bill?
            //Returning to the above problem, replace hard-coded values of 4(number of diners) and 13(cost per diner) 
            // with values provided by the user. 
            //How nice!The restaurant is having Customer Appreciation Week.
            //If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            //Otherwise, they’ll receive a 5 % discount.

            Console.WriteLine("How many diners are there?");
            int numDiners = int.Parse(Console.ReadLine());
            Console.WriteLine("How much is each person paying?");
            float costPerPerson = float.Parse(Console.ReadLine());
            float totalBill = numDiners * costPerPerson;
            Console.WriteLine($"The total cost of the meal is $ {totalBill}");
            //could also define the discount as a variable that changes - define the variable initially before the 'if'
            float billDiscount = 0.0f;

            if (totalBill > 50)
            {
                billDiscount = 1.1f;
                float discountedBill10 = totalBill - totalBill*0.1f;
                //another way is to write without creating another variableName is 
                //totalBill = totalBill / billDiscount      or    totalBill /= billDiscount;
                Console.WriteLine("This is your lucky day! You get a 10% discount! Your total cost is now $" + discountedBill10);
                Console.WriteLine("Each person now owes $" + discountedBill10 / numDiners);
                              
            }
            else
            {
                float discountedBill5 = totalBill -totalBill*0.05f;
                Console.WriteLine("You get a 5% discount. Your total cost is now $" + discountedBill5);
                Console.WriteLine("Each person now owes $" + discountedBill5 / numDiners);
            }



        }
    }
}
