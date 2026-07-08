using System;

namespace DataTypes
{
    public class DecimalExample
    {
        public static void Run()
        {
            // Display the title
            Console.WriteLine("----- DECIMAL DATA TYPE -----");

            // 'decimal' is mainly used for money calculations.
            // Add 'm' at the end of the value.
            decimal amount = 99999.99m;

            // Display the value.
            Console.WriteLine("Amount : " + amount);

            Console.WriteLine();
        }
    }
}