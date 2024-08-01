﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string textAge = "-23";
            //int age = Convert.ToInt32(textAge);
            //Console.WriteLine(age);

            // using var lets the compiler decide the data type
            // some types still need the appendage (L,F,D) Dont do this too much
            // var age = 23;
            // Console.WriteLine(age);

            // Constants

            //const int vat = 20;
            //const double percentVAT = vat / 100D;
            //int balance = 1000;

            //Console.WriteLine(balance * percentVAT);

            // converting types
            //string textBigNumber = "900000000";

            //long bigNumber = Convert.ToInt64(textBigNumber);
            //Console.WriteLine(bigNumber);

            //string textNegative = "-55.2";
            //double negative = Convert.ToDouble(textNegative);
            //Console.WriteLine(negative);

            //string textPrecision = "5.00001";
            //float precision = Convert.ToSingle(textPrecision);
            //Console.WriteLine(precision);

            //string textMoney = "14.99";
            //decimal money = Convert.ToDecimal(textMoney);
            //Console.WriteLine(money);

            //string name = "Gabriel";
            //Console.WriteLine(name);

            //string phoneNum = "9321877733";
            //Console.WriteLine(phoneNum);

            //int age = 35;
            //Console.WriteLine(age);

            // REMAINDER
            // 10 is even because 0 r
            //int firstNum = 10;
            //int secondNum = 2;
            //int remainder = firstNum % secondNum;
            //Console.WriteLine(remainder);

            // INPUT
            // .Write keeps the input on the same line
            // while .WriteLine puts a terminus at the line end

            //Console.WriteLine("Hello my name is Gabe");

            /*
                Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            // Console.WriteLine(name);
            
            Console.Write("Enter your age: ");
            
            int age = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(age);
            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);
            
            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
            if (age >= 18 || age <= 25)
            {
                Console.WriteLine("You are between 18 and 25");
            }
            else if (age >= 26)
            {
                Console.WriteLine("You are 26 or older");
            }
            }
            */


            /* Console.Write("Enter the first number: ");
             int firstNum = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();

             Console.Write("Enter the second number: ");
             int secondNum = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();
             int answer = firstNum * secondNum;
             int actualAnswer = 0;

             Console.WriteLine();
             Console.Write("What is the product of " + firstNum + " X " + secondNum + "?: ");
             Console.WriteLine();


              while (answer != actualAnswer)
             {
                 Console.Write("Enter your answer: ");
                 string answerInput = Console.ReadLine();
                 actualAnswer = Convert.ToInt32(answerInput);

                 if (answer != actualAnswer)
             {
                 Console.WriteLine("No, not quite.");
                     Console.WriteLine();
                 }
             } */

            // DO WHILE will check condition at the end of the loop
            // otherwise it will continue
            // in this example, it allows for the possibility of the answer actually being 0

            /* do
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("No, not quite.");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");

            */






            /* SWITCH STATEMENTS*/

            /* Console.Write("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day == 1)
            {
                Console.WriteLine("Mon");
            }

            switch (day)
            {
                case 1:
                    Console.WriteLine("Mon");
                    break;
                /* Adding an empty case is the same as saying OR with the one below it */
            /* case 0: */
            //case 2:
            //    Console.WriteLine("Tues");
            //    break;
            //case 3:
            //    Console.WriteLine("Wed");
            //    break;
            //case 4:
            //    Console.WriteLine("Thur");
            //    break;
            //case 5:
            //    Console.WriteLine("Fri");
            //    break;
            //case 6:
            //    Console.WriteLine("Sat");
            //    break;
            //case 7:
            //    Console.WriteLine("Sun");
            //    break;

            /* The default will run if none of the values match the above switch */
            /*default:
                Console.WriteLine("Invalid, enter a number between 1 and 7");
                break ;
        } */

            // FOR LOOPS

            /*
            Console.Write("What do you want to say?: ");
            string message = Console.ReadLine();
            Console.Write("How many times do you want to say it?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("You should rethink your choices.");
            }
            else
            {
            for (int i = 0; i < loopCounter; i++) 
            {
                Console.WriteLine(message);
            }
            }

            
            
            // writes on even numbers
            /* for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);

            } */

            // WHILE LOOPS

            // CONDITIONALS

            /* int age = -10;

             if (age >= 0)
             {
                 Console.WriteLine("Valid");
             }
             else
             {
                 Console.WriteLine("Invalid");
             }


             Console.WriteLine(age >= 0 ? "Valid" : "Invalid");
            */

            // NUMERICAL FORMATTING

            // the first argument in format is the index of the first number followed with the number of decimals
            // this also rounds up
            // # trims off any trailing zeros

            // using System.Globalization lets you use other currency symbols

            // the "C" fetches the symbol for local currency
            // the numbers appended represent decimal places displayed

            /* double value = 1000D / 12.34D;
             Console.WriteLine(value);
             Console.WriteLine(string.Format("{0:0.00}", value));
             Console.WriteLine(string.Format("{0:0.#}", value));

             double money = 10D / 3D;
             Console.WriteLine(money);
             Console.WriteLine(string.Format("${0:0.00}", money));
             Console.WriteLine(money.ToString("C"));
             Console.WriteLine(money.ToString("C0"));
             Console.WriteLine(money.ToString("C1"));
             Console.WriteLine(money.ToString("C2"));

             // can use various cultures to format numbers
             Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture ));
             Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-GB") ));
            */

            // TRYPARSE


            /* bool success = true;

             while (success)
             {
                 Console.Write("Enter a number: ");
                 string numInput = Console.ReadLine();
                 //int num = 0; dont need this anymore because we added a declaration to the OUT parameter

                 if (int.TryParse(numInput, out int num))
                 {
                     success = false;
                     Console.WriteLine(num);
                 }
                 else
                 {
                     Console.WriteLine("failed to convert");
                 }

             }
            */

            // tries to convert string to int32 and then if successful, stores value in the 2nd argument
            // if it fails because of invalid input, it will not throw error but instead returns bool
            // the bool lets us check whether 0 shows up due to failure or actual user input

            // TIMES TABLE EXERCISE

            Console.Write("Enter a number to multiply out, you dirty dog: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                // This CONDITIONAL FORMATTING is cool, its allowing you to plug in the values listed after the " "
                Console.WriteLine("{0} x {1} = {2}", i, number, number * i);
            }


            Console.ReadLine();
        }
    }
}
