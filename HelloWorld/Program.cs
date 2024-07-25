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
            int firstNum = 1675;
            int secondNum = 12;
            int remainder = firstNum % secondNum;
            Console.WriteLine(remainder);


            

            Console.ReadLine();
        }
    }
}
