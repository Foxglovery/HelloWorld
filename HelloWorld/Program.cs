using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            /*
            Console.Write("Enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int answer = firstNum * secondNum;

            Console.WriteLine();
            Console.Write("The product of " + firstNum + " X " + secondNum + " is: ");
            int answerInput = Convert.ToInt32(Console.ReadLine());

            if (answerInput == answer)
            {
                Console.WriteLine("Well done, you can do math!");
            }
            else
            {
                Console.WriteLine("maybe study a bit more?");
            }*/

            /* SWITCH STATEMENTS*/

            Console.Write("Enter a day of the week: ");
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
                case 2:
                    Console.WriteLine("Tues");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thur");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;

                /* The default will run if none of the values match the above switch */
                default:
                    Console.WriteLine("Invalid, enter a number between 1 and 7");
                    break ;
            }


            Console.ReadLine();
        }
    }
}
