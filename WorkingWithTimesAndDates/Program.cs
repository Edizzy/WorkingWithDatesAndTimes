using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTimesAndDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pleas type in a date as follows xx/xx/xxxx.");
            DateTime myValue = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(myValue.ToLongDateString());
            Console.ReadLine();
            Console.WriteLine("Please type a number of days from now to see the date.");
            string numberOfDays = Console.ReadLine();
            int number = Int32.Parse(numberOfDays);
            DateTime threeDaysHence = myValue.AddDays(number);
            Console.Write("{0} days from your date: " + threeDaysHence.ToLongDateString() , numberOfDays);
            Console.ReadLine();
        }
    }
}
