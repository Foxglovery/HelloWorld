﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
using System.CodeDom;

namespace HelloWorld
{
    class Test
    {
        public static void something()
        {
            Console.WriteLine("Test");
        }
    }
    internal class Program
    {
        // ClASSES constructor
        // dont have to give default values for the class as opposed to structures
        // which means you can have multiple constructors for different values (name, age)
        // you can create empty instances and you can create instances with only certain values defined

        //class Person
        //{
        //    public string name;
        //    public int age;

        //    public Person(string name, int age)
        //    {
        //        this.name = name;
        //        this.age = age;
        //    }
        //    public Person(string name)
        //    {
        //        this.name = name;
        //        this.age = -1;
        //    }
        //    public Person(int age)
        //    {
        //        this.age = age;
        //        this.name = "";
        //    }
        //    public Person()
        //    {

        //    }
        //}

        // CLASS FUNCTIONS

        class Person
        {
            // or you can use auto-properties for get/set if no logic is required:
            //public string Name { get; set; }
            //public int Age { get; set; }

            private string name;
            private int age;
            

            // public class variables are known as Fields. These act as middle-men and replace the longer getter/setters
            public string Name
            {
                get => name;
                set => name = !string.IsNullOrEmpty(value) ? value : "Invalid Name";
            }
            // if your setter needs logic, its best to keep the curly brace style like below, otherwise arrow will be best
            //public string Name { get => name; set => name = value; }
            //public int Age { get => age; set => age = value; }
            public int Age
            {
                get => age;
                set => age = value >= 0 && value <= 150 ? value : -1;
            }

            public Person(string name, int age)
            {             
                // using this. refers to the global variable instead of the local one
                Name = name;
                Age = age;
            }
            // CLASS PROPERTIES



            // in order to change fields when they are private, use getters and setters
            //public void SetName(string name)
            //{
            //    // using the ternary here saves several lines
            //    this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
            //}

            //public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";

            ////public string GetName()
            ////{
            ////return name;
            ////}
            //public string GetName() => name;


            //public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;


            ////public int GetAge()
            ////{
            ////    return age;
            ////}
            //// using arrow function
            //public int GetAge() => age;
            public string ReturnDetails()
            {
                return $"Name: {Name}\nAge: {Age}";            
            }

            // adding a ToString overide allows you to naturally print out to the screen
            public override string ToString()
            {
                return ReturnDetails();
            }
            // equality override allows equality testing
            public override bool Equals(object obj)
            {
                if (obj is Person)
                {
                    Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
                }
                return false;
            }
        }

        

        //struct Person
        //{
        //   public string name;
        //   public int age;
        //   public int birthMonth;

        //   // using a constructor
        //   public Person(string name, int age, int birthMonth)
        //    {
        //        // using this. references the global scoped variable above
        //        this.name = name;
        //        this.age = age;
        //        this.birthMonth = birthMonth;
        //    }
        //}
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

            //Console.Write("Enter a number to multiply out, you dirty dog: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    // This CONDITIONAL FORMATTING is cool, its allowing you to plug in the values listed after the " "
            //    Console.WriteLine("{0} x {1} = {2}", i, number, number * i);
            //}

            // FIZZ BUZZ EXERCISE

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //THIS IS THE ORIGINAL
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz!");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if(i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //A MORE EFFICIENT WAY is to store the modulus rules as booleans

            //bool threeDiv = false;
            //bool fiveDiv = false;

            //for (int i = 1; i <= number; i++)
            //{
            //    threeDiv = i % 3 == 0;
            //    fiveDiv = i % 5 == 0;

            //    if (threeDiv && fiveDiv)
            //    {
            //        Console.WriteLine("FizzBuzz!");
            //    }
            //    else if (threeDiv)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (fiveDiv)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // VERBATIM STRING LITERALS
            // when using backslash in string you must use 2 because 1 backslash escapes the next character
            //string speech = "He said \"something\"";
            //string path = "C:\\Users\\CoffeeNCode\\OtherPaths.img\nNewLineTest";
            //Console.WriteLine(path);
            //Console.WriteLine(speech);

            //// the @ is verbatim identifier: means it is literally what you will see
            //path = @"C:\Users\CoffeeNCode\OtherPaths.img" + "\nNewLineTest";
            //Console.WriteLine(path);

            //string name = "Hello \"someone\"";
            //Console.WriteLine(name);

            //name = "Hello 'someone'";

            // STRING FORMATTING

            //string name = "Aba";
            //int age = 32;
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);

            //Console.WriteLine();

            //Console.WriteLine("Name: " + name + "\nAge: " + age);
            //// with composite formatting
            //Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
            //Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            // STRING INTERPOLATION

            //string name = "Aba";
            //int age = 32;
            //Console.WriteLine($"Your name is {name} and your age is {age}");

            //// STRING CONCATENATION
            //string test = string.Concat("Your name is ", name, " and your age is ", age);
            //Console.WriteLine(test);

            //string[] names = new string[] { "Aba", "Test", "Test" };
            //Console.WriteLine(string.Concat(names));

            // EMPTY STRING

            // string name = string.Empty;
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //if (name != "")
            //{
            //    Console.WriteLine($"Your name is {name}");

            //}
            //else
            //{
            //    Console.WriteLine("name is Empty");
            //}

            // STRING EQUALITY

            //string message = "Hello";
            //string compare = "Hello";

            //if (message.Equals(compare))
            //{
            //    Console.WriteLine("Same");
            //}
            //else
            //{
            //    Console.WriteLine("Different");
            //}

            //Console.Write("enter your name: ");
            //string name = Console.ReadLine();

            //// best practice to use the .Equals method on string
            //if (!name.Equals(""))
            //{
            //    Console.WriteLine("Your name is " + name);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid name input");
            //}

            //// comparing an object and string, will not work with ==
            ///
            //// Equals method checks the values not where they are in memory
            //char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            //object newCompare = new string(chars);

            //if (message.Equals(newCompare))
            //    Console.WriteLine("Same");
            //else
            //    Console.WriteLine("Different");

            // STRING INTERATION (LOOPING)

            //string message = "C# is awesome";
            ////Console.WriteLine(message[0]);
            ////Console.WriteLine(message[1]);
            ////Console.WriteLine(message[2]);
            ////Console.WriteLine(message[3]);

            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write(message[i]);
            //    // threading puts a delay or sleep on printing the characters like a typewriter
            //    Thread.Sleep(100);
            //}
            //Console.WriteLine();

            //Console.WriteLine(message.Contains("C"));

            //bool contains = false;

            //for (int i = 0;i < message.Length; i++)
            //{
            //    if (message[i].Equals('C'))
            //    {
            //        contains = true;
            //    }
            //}

            //Console.WriteLine(contains);

            // STRING IsNullOrEmpty FUNCTION

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine($"Your name is {name}");
            ////if (name != "")
            ////    Console.WriteLine("0");
            ////// OR
            ////if (!name.Equals(""))
            ////    Console.WriteLine("1");

            //// OR
            //// using IsNullOrEmpty checks both conditions and is better
            //// because using a function on a null value will throw exception
            //if (!string.IsNullOrEmpty(name))
            //{
            //    if (!name.Equals(""))
            //    {
            //        Console.WriteLine("2");
            //    }

            //} 

            // PRINT STRING IN REVERSE EXERCISE

            //Console.Write("What message would you like to print?: ");
            //string message = Console.ReadLine();

            //Console.WriteLine();

            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write(message[i]);
            //    Thread.Sleep(150);
            //}

            //Console.WriteLine();
            //for (int i = message.Length -1; i >= 0; i--)
            //{  
            //    Console.Write(message[i]);
            //    Thread.Sleep(150);
            //}

            // also there is a snippet for reversed for loop "forr"

            // EXCERCISE PASSWORD CHECKER

            // splitting the if statements up allows for different error messages

            //Console.Write("Please enter password: ");
            //string password = Console.ReadLine();

            //Console.Write("Please re-enter password: ");
            //string passwordC = Console.ReadLine();

            //if (!password.Equals(string.Empty))
            //{
            //    if (!passwordC.Equals(string.Empty))
            //    {
            //        if (password.Equals(passwordC))
            //        {
            //            Console.WriteLine("Passwords match");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Password do not match");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter password confirmation");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter password");
            //}

            // ARRAYS

            // adding the 3 after the instantiation tells it that there are 3 positions
            // int[] numbers = new int[3];

            //Console.Write("Enter a number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

            //for (int i  = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}

            // Console.WriteLine();
            // this does the same thing and no brackets are needed
            // but cannot choose how many iterations to loop through; it does each
            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            // ANGLE SUM EXERCISE

            // const int angleCount = 3; //// having a number here is called magic number and is confusing
            // int[] angles = new int[angleCount];

            //for (int i = 0; i < angles.Length; i++)
            // {
            //     Console.Write($"Enter angle {i + 1}: ");
            //     angles[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // int angleSum = 0;

            //foreach (int angle in angles)
            // {
            //     angleSum += angle;
            // }

            //if (angleSum == 180)
            // {
            //     Console.WriteLine("Valid");
            // }
            //else
            // {
            //     Console.WriteLine("Invalid");
            // }

            // OR
            // without using an array

            //const int angleCount = 3;
            //int angleSum = 0;

            //for (int i = 0; i < angleCount; i++)
            //{
            //    Console.Write($"Enter angle {i + 1}: ");
            //   angleSum += Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            // ARRAY SORTING

            //int[] numbers = new int[]
            //{
            //    2, 1, 7, 9, 5, 6, 7, 8, 9
            //};

            //string test = "";
            //test.Replace(" ", "");
            //Array.Sort(numbers);

            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            // ARRAY REVERSAL

            //int[] numbers = new int[]
            //{
            //    0, 1, 2, 3, 4, 5, 6
            //};

            //Array.Reverse(numbers);

            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();
            //// or do it manually

            //int[] sortedNumbers = new int[numbers.Length];

            //int x = 0;
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    sortedNumbers[x] = numbers[i];
            //    x++;
            //   // Console.Write($"{i} ");
            //}

            //foreach (int num in sortedNumbers)
            //{
            //    Console.Write($"{num} ");
            //}

            // ARRAY CLEARING

            //int[] numbers = new int[]
            //{
            //    0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            //};

            ////Array.Clear(numbers, 0, numbers.Length);
            //Array.Clear(numbers, 5, 5);


            ////or manually

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = default;
            //}

            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} ");
            //}

            // ARRAY IndexOf

            //int[] numbers = new int[]
            //{
            //    90, 199, 22, 50, 30
            //};

            //Console.Write("Enter number to search: ");
            //int search = Convert.ToInt32(Console.ReadLine());

            ////int position = Array.IndexOf(numbers, search);
            //// can also give IndexOf a start index, as well as a range limit
            //int position = Array.IndexOf(numbers, search, 0, 2);

            //if (position > -1)
            //{
            //    Console.WriteLine($"Number {search} has been found at position {position + 1}.");

            //}
            //else
            //{
            //    Console.WriteLine($"{search} not found");
            //}


            // LISTS

            //int[] numbers = new int[3]
            //{
            //    1, 2 , 3
            //};

            //// list constructor can specify the capacity or it can be left blank to grow as needed
            //List<int> listNumbers = new List<int>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            //}

            //for (int i = 0;i < listNumbers.Count; i++)
            //{
            //    Console.Write($"{listNumbers[i]} ");
            //}

            // DICTIONARIES which store key value pairs

            // keys must be unique and not null

            //Dictionary<int, string> names = new Dictionary<int, string>
            //{
            //    // KeyValue Pair
            //    { 1, "Aba" },
            //    { 2, "Test" },
            //    { 3, "Test" }
            //};

            //// must use ElementAt because i is an index and not the key being referenced
            //for (int i = 0; i < names.Count; i++)
            //{
            //    KeyValuePair<int, string> pair = names.ElementAt(i);

            //    Console.WriteLine($"{pair.Key} - {pair.Value}");


            //    //Console.WriteLine(names.ElementAt(i).Value);
            //}

            //// with a foreach loop

            //foreach (KeyValuePair<int, string> item in names)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}

            //Dictionary<string, string> teachers = new Dictionary<string, string>()
            //{
            //    {"Math", "Aba" },
            //    {"Science", "Test" }
            //};
            //// returns the value from the specified key but can break if nonexistent
            //// instead you should check to ensure it exists
            //// Console.WriteLine(teachers["Math"]);

            //if (teachers.TryGetValue("Math", out string teacher))
            //{
            //    Console.WriteLine(teacher);

            //    teachers["Math"] = "Joe";
            //}
            //else
            //{
            //    Console.WriteLine("teacher not found");
            //}

            //if (teachers.ContainsKey("Math"))
            //{
            //    teachers.Remove("Math");
            //}

            //foreach (var item in teachers)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}

            // EVEN_ODD LIST SPLIT EXERCISE

            //List<int> even = new List<int>();
            //List<int> odd = new List<int>();

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        even.Add(i);
            //    }
            //    else
            //    {
            //        odd.Add(i);
            //    }
            //}
            //Console.WriteLine("Even: ");
            //foreach (int i in even)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Odd: ");
            //foreach (int i in odd)
            //{
            //    Console.Write($"{i} ");
            //}

            // ARRAY OF MULTIPLES EXERCISE

            //int num = 7;
            //int length = 12;
            //int counter = 0;
            //int[] multiples = new int[length];

            //// or you can declare int counter = 0 and add counter++ with a comma to the for loop
            //for (int i = 1; i <= multiples.Length; i++, counter++)
            //{
            //    multiples[counter] = num * i;
            //}
            //Console.WriteLine($"Multiples of {num}: ");

            //foreach (int item in  multiples)
            //{
            //    Console.Write($"{item} ");
            //}

            // FUNCTIONS

            // .NET must have a static function called Main

            //Test.something();
            //// without static keyword it would look like this:
            //// Test test = new Test();
            //// test.something();

            //WelcomeMessage();
            //CreateAndPrintArray();
            //bool success = int.TryParse("123", out int result);
            //Console.WriteLine(success);

            // static means that a "new" instance does not need to be created
            // public means it can be used anywhere
            //static void WelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to my program");
            //}

            //static void CreateAndPrintArray()
            //{
            //    int[] numbers = new int[3] { 0, 1, 2 };

            //    foreach (var item in numbers)
            //    {
            //        Console.WriteLine($"{item} ");    
            //    }
            //}

            // RETURN TYPE FUNCTIONS

            // specifying Console.Title = "blah blah blah" will display blah... ontop the console

            //Console.Title = $"{ReturnName()} - {ReturnAge()}";
            //PrintIntroduction();

            //int[] numbers = new int[3];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = ReadNumberFromConsole();
            //}

            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}

            //int[] newNumbers = CreateRandomArray();

            // FUNCTION PARAMETERS

            // Console.WriteLine(Add(5, 5));


            //int num1 = ReadInt("Enter first number");
            //int num2 = ReadInt("Enter second number");
            //int result = Add(num1, num2);

            //Console.WriteLine(result);

            //string name = ReadString("Enter your name");
            //int age = ReadInt("Enter your age");
            //string details = UserDetails(name, age);
            //Console.WriteLine(details);

            // OPTIONAL PARAMETERS

            //int result = Add(5);
            //Console.WriteLine(result);

            //PrintName("aba");

            // NAMED PARAMETERS
            //string nameInput = "Gabe";
            //int ageInput = 33;
            //string addressInput = "1 Somewhere Vale";

            //// using the : and referencing the variable allows them to be in any order
            //PrintDetails(age:ageInput, 
            //             name:nameInput,
            //             address:addressInput);

            // OUT PARAMETERS

            //int num = 0;
            //test(out num);
            //Console.WriteLine(num);

            // this is what IndexOf is doing --->
            //List<string> shoppingList = new List<string>
            //{
            //    "Coffee", "Milk"
            //};

            //Console.WriteLine(shoppingList.IndexOf("Coffee"));
            ////Console.WriteLine(FindInList("milk", shoppingList, out int index));

            //Console.Write("Enter an item to search: ");
            //string query = Console.ReadLine();

            //if (FindInList(query, shoppingList, out int index))
            //{
            //    Console.WriteLine($"Found {query} at index {index}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            //int index = -1;

            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    if (shoppingList[i].ToLower().Equals("milk"))
            //    {
            //        index = i;
            //    }
            //}
            //bool found = index > -1;
            //Console.WriteLine(found ? "Found" : "Not Found");

            // REFERENCE PARAMETERS
            // adding the ref keyword links to two variables in different scopes
            // passing by ref is technically quicker
            //int num = 10;
            //string name = "Gabe";
            //string newName = "Josephone";
            //Assign(ref num, ref name);
            //Console.WriteLine(num);
            //Console.WriteLine(name);

            //ChangeName(ref name, ref newName);
            //Console.WriteLine(name);

            //Console.Write("Enter your new name: ");
            //string newName = Console.ReadLine();

            //if (ChangeName(ref name, ref newName))
            //{
            //    Console.WriteLine($"Your new name is {name}");
            //}
            //else
            //{
            //    Console.WriteLine("New name cannot be empty or null");
            //}

            // AREA OF TRIANGLE EXERCISE

            //int width = ReadInt("Enter the width of the triangle: ");
            //int height = ReadInt("Enter the height of the triangle: ");

            //Console.WriteLine($"The area is {TriangleArea(width, height)}");

            // SUM OF ARRAY EXERCISE

            //int[] numbers = new int[]
            //{
            //    0, 1, 2, 3, 4, 5, 6
            //};

            //if (SumOfNumbers(numbers, out int total))
            //{
            //    Console.WriteLine($"The total is {total}");
            //}
            //else
            //{
            //    Console.WriteLine("Cannot sum an empty array");
            //}

            // EXCEPTION HANDLING



            // System.FormatException
            // System.OverflowException

            //bool looping = true;

            //while (looping)
            //{
            //    try
            //{
            //    Console.Write("Enter a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    looping = false;
            //    Console.WriteLine(num);
            //}
            //    // "Exception" catches all exceptions so put it last just in case
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Please only enter numerical values");
            //    }
            //    catch (OverflowException)
            //    {
            //    Console.WriteLine("Please limit your input to 2 billion");
            //    }
            //    catch (Exception)
            //    {
            //    Console.WriteLine("Something has gone wrong!");
            //    }
            //}

            // PRINTING ERROR MESSAGES

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num);
            //}
            //// naming the exception allows you to access things like the error message in the catch
            //catch (Exception e)
            //{

            //    Console.WriteLine($"Error: {e.Message}");
            //}

            //Console.WriteLine("Goodbye!");

            // CUSTOM TRYPARSE EXERCISE
            //bool looping = true;

            //while (looping)
            //{
            //    try
            //    {
            //        Console.Write("Enter a number: ");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        looping = false;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Please only enter integers");
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Please keep number under 2 bilion");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Error: {e.Message}");
            //    }
            //}  GETS TURNED INTO THIS BELOW

            //Console.Write("Enter a number: ");
            //if (TryParse(Console.ReadLine(), out int result))
            //{
            //    Console.WriteLine("Yay" + result);
            //}
            //else
            //{
            //    Console.WriteLine("Oh no");
            //}

            // DEBUGGING

            //string name = "Gabe";
            //int age;
            //age = 35;

            //if (age > 18)
            //{
            //    Console.WriteLine("18+");
            //}

            //PrintDetails(name, age);

            //string message = ReadFromConsole("Enter anything: ");
            //Console.WriteLine(message);

            // DEBUGGING EXERCISE

            //int age = 55;

            //if (age > 18 && age < 30)
            //{
            //    Console.WriteLine("Over 18");
            //}
            //else if (age > 30 && age < 50)
            //{
            //    Console.WriteLine("Over 30");
            //}
            //else if (age > 50)
            //{
            //    Console.WriteLine("Over 50");
            //}

            // STRUCTURES

            // structure gets declared above the Main scope
            //string name = "Gabe";
            //int age = 23;
            //int birthMonth = 5;

            //Person person;

            //person.name = "Gabe";
            //person.age = 35;
            //person.birthMonth = 5;


            //Console.WriteLine($"{person.name}-{person.age}-{person.birthMonth}");

            //string newName = "";
            //int newAge = 0;
            //int newBirthMonth = 0;
            //ReturnPerson(ref newName, ref newAge, ref newBirthMonth);
            //Console.WriteLine($"{newName} - {newAge} -{newBirthMonth}");

            //Person person = ReturnPerson();
            //Console.WriteLine($"{person.name} - {person.age} -{person.birthMonth}");


            // CLASSES
            //Console.Write("Enter a name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter an age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Person person = new Person(name, age);

            //if (!string.IsNullOrEmpty(name))
            //{
            //    Console.WriteLine(person.name);
            //}

            //if (person.age > -1)
            //{
            //    Console.WriteLine(person.age);
            //}

            // CLASS FUNCTIONS
            // CLASS FIELDS
            //Person person = new Person("Gilly", 34);
            // can use dot notation because those variables are defined in the constructor
            // THIS WAY IS NOT PREFERED
            // Console.WriteLine(ReturnDetails(person));
            // ***for function calls that are inside the class, use dot notation
            //Console.WriteLine(person.ReturnDetails());
            // these fields can be changed because the class is set to public
            //person.name = "Jipper";
            //person.age = 77;
            // instead, use the setter function made in the class
            //person.SetName("Jipper");
            //person.SetAge(44);
            //Console.WriteLine(person.ReturnDetails());
            // then with the getter
            //Console.WriteLine($"Hello, your name is {person.GetName()} and your age is {person.GetAge()}");

            // CLASS VARIABLE/FUNCTION SCOPE

            Person person = new Person("Aba", 23);
            Person test = new Person("Aba", 23);

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not Same");
            }
            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString());
            Console.WriteLine(person);
            //person.Name = "Harry";
            //person.Age = 44;
            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");

            // Class ToString function Overide
           
            
            Console.ReadLine();
        }

        // CLASS VARIABLE / FUNCTION SCOPE
        // in order to access variables/ class objects created in main, must be passed in as parameters
        // if you want variables accessable to a class, need to put them at the top of the class declaration
        //static void something(Person person)
        //{
        //    Console.WriteLine(person.ReturnDetails());
        //}

        // CLASS FUNCTIONS
        // this function is not dry and doesnt utilize the class
        // static string ReturnDetails(string name, int age)
        //{
        //    return $"Name: {name}\nAge: {age}";
        //}
        
        // now if fields are added to the class, nothing in the function has to change
        // this function can be included inside the class, see above
        // THIS IS AN EXAMPLE OF POOR STRUCTURE BECAUSE FUNCTIONS SHOULD BE IN THE CLASS
        //static string ReturnDetails(Person person)
        //{
        //    return $"Name: {person.name}\nAge: {person.age}";
        //}

        // return type is the structure, Person
        //static Person ReturnPerson()
        //{
        //    Console.Write("Enter your name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Enter your age: ");
        //   int age = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Enter your birthmonth: ");
        //    int birthMonth = Convert.ToInt32(Console.ReadLine());

        //    //Person person;
        //    //person.name = name;
        //    //person.age = age;
        //    //person.birthMonth = birthMonth;

        //    return new Person(name, age, birthMonth);
        //}

        // this uses ref to assign to the parameters passed in but becomes tedious. 
        //static void ReturnPerson(ref string name, ref int age, ref int newBirthMonth)
        //{
        //    Console.Write("Enter your name: ");
        //    name = Console.ReadLine();

        //    Console.Write("Enter your age: ");
        //    age = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Enter your birthmonth: ");
        //    newBirthMonth = Convert.ToInt32(Console.ReadLine());


        //}

        //static void PrintDetails(string name, int age)
        //{
        //    Console.WriteLine($"Name: {name}");
        //    Console.WriteLine($"Age: {age}");
        //}

        //static string ReadFromConsole(string message)
        //{
        //    Console.Write(message);
        //    return Console.ReadLine();
        //}

        //static bool TryParse(string input, out int result)
        //{
        //    result = -1;

        //    try
        //    {
        //        result = Convert.ToInt32(input);
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }



        //}

        //static bool SumOfNumbers(int[] numbers, out int total)
        //{
        //    total = 0;
        //    if (numbers.Length > 0)
        //    {

        //        foreach (int number in numbers)
        //        {
        //            total += number;
        //        }

        //    return true;

        //    }

        //    return false;

        //}

        //static int ReadInt(string message)
        //{
        //    Console.Write(message);
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        //static int TriangleArea(int width, int height)
        //{

        //    return (width * height) / 2;
        //}

        //static void Assign(ref int num, ref string name)
        //{
        //    num = 20;
        //    name = "Aba";
        //}

        // setting the return type to bool allows us to check if conditions are met
        // before running the function
        //static bool ChangeName(ref string name, ref string newName)
        //{
        //    if (!string.IsNullOrEmpty(newName))
        //    {
        //        name = newName;
        //        return true;
        //    }

        //    return false;

        //}

        //static bool FindInList(string s, List<string> list, out int index)
        //{
        //    index = -1;

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i].ToLower().Equals(s.ToLower()))
        //        {
        //            index = i;
        //        }
        //    }

        //    return index > -1;
        //}
        //static bool TryParse(string s, out int result)
        //{
        //    result = 0;
        //    return true;
        //}

        //static void test(out int num)
        //{
        //    num = 5;
        //    //return num;
        //    //return true;
        //}

        // OUT PARAMETERS (functions from above)

        // NAMED PARAMETERS (functions from above)

        //static void PrintDetails(string name, int age, string address)
        //{
        //    Console.WriteLine($"Hello, my name is {name}. My age is {age}, and I live at {address}");
        //}

        // OPTIONAL PARAMETERS (functions from above)

        // using the default value for a parameter int is 0
        // static int Add(int a, int b = default) OR
        //static int Add(int a, [Optional] int b)
        //{
        //    return a + b;
        //}

        //static void PrintName(string name = "Gabe")
        //{
        //    Console.WriteLine($"My name is {name}");
        //}

        // PARAMETERS (Functions from above)

        //static int Add(int a, int b)
        //{
        //    return a + b;        
        //}

        //static int ReadInt(string message)
        //{
        //    Console.Write($"{message}: ");
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        //static string ReadString(string message)
        //{
        //    Console.Write($"{message}: ");
        //    return Convert.ToString(Console.ReadLine());
        //}

        //static string UserDetails(string name, int age)
        //{
        //    return $"Hello, my name is {name} and my age is {age}";
        //}

        //static int[] CreateRandomArray()
        //{
        //    int[] numbers = new int[3]
        //    {
        //        0, 1, 2
        //    };

        //    return numbers;
        //}

        //static int ReadNumberFromConsole()
        //{
        //    Console.Write("Enter a number: ");
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        // dont use global vars, instead use return type funcs
        //static string ReturnName()
        //{
        //    return "Gabe";
        //}

        //static int ReturnAge()
        //{
        //    return 36;
        //}

        //static void PrintIntroduction()
        //{
        //    Console.WriteLine($"My name is {ReturnName()} and my age is {ReturnAge()}");
        //}


    }
}
