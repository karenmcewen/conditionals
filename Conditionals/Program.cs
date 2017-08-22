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

              */

            //Example 3
            /*You're responsible for providing a demographic report for your local school district based on age. 
            To do this, you're going to determine which 'category' each person fits into based on their age. 
            The person's age will determine which category they should be in:
                If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms' 
                If they're 3 or 4 and should be in preschool print : 'Preschool Maniac' 
                If they're from 5 to 11 and should be in elementary school print : 'Elementary School' 
                From 12 to 14: 'Middle School' 
                From 15 to 18: 'High School' 
                From 19 to 22: 'College'
                From 23 to 65: 'Working for the Man' 
                From 66 to 100: 'The Golden Years' 
            If the age of the person is less than 0 or more than 100 - it might be an alien - 
                print: "This program is for humans".
            

            Console.WriteLine("How old are you today?");
            int personsAge = int.Parse(Console.ReadLine());

            if (personsAge >=0 && personsAge <=2)
            {
                Console.WriteLine("'Still in Mama's Arms'");
            }
            else if (personsAge >= 3 && personsAge <= 4)
            {
                Console.WriteLine("'Preschool Maniac' ");
            }

            else if (personsAge >= 5 && personsAge <= 11)
            {
                Console.WriteLine("'Elementary School' ");
            }

            else if (personsAge >= 12 && personsAge <= 14)
            {
                Console.WriteLine("'Middle School' ");
            }

            else if (personsAge >= 15 && personsAge <= 18)
            {
                Console.WriteLine("'High School' ");
            }
            else if (personsAge >= 19 && personsAge <= 22)
            {
                Console.WriteLine("College");
            }

            else if (personsAge >= 23 && personsAge <= 65)
            {
                Console.WriteLine("Working for the man");
            }

            else if (personsAge >= 66 && personsAge <= 100)
            {
                Console.WriteLine("The Golden Years");
            }

            else
            {
                Console.WriteLine("This program is only for humans.");
            }
            */

            //Example - write a console application that asks the user for a number
            //tell whether the number is even or odd
            //hint: use the modulus operator % which outputs the remainder of the division of two integers

            Console.WriteLine("Pick a number, any number!");
            int yourNumber = int.Parse(Console.ReadLine());
            if (yourNumber % 2 > 0) //alternatively,  ==0 to is true if the number is even
            {
                Console.WriteLine("The number " +yourNumber + " is odd");
            }
            else
            {
                Console.WriteLine("Your number " + yourNumber + " is even!");
            }

            //fizzbuzz example - if divisible between by 5 print 'fizz', by 3 print 'buzz', 
            //both 5 and 3 then print 'fizzbuzz'
        }
    }
}
