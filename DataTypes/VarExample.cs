using System;

namespace DataTypes
{
    public class VarExample
    {
        public static void Run()
        {
            // Display the title
            Console.WriteLine("----- VAR KEYWORD -----");

            // 'var' lets the compiler decide the data type automatically.
            var city = "Chennai";      // string
            var marks = 95;            // int
            var percentage = 89.5;     // double

            // Display the values.
            Console.WriteLine("City : " + city);
            Console.WriteLine("Marks : " + marks);
            Console.WriteLine("Percentage : " + percentage);

            Console.WriteLine();
        }
    }
}