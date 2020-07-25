using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new 
                    { 
                        myName = "Aaron",
                        myAge = 32,
                        myDouble = 12.56,
                    };

            var greeting = $"My name is {me.myName}, I am {me.myAge}, and my double is {me.myDouble}.";
            
            var list = new string[3] { "Money", "Power", "Buttcheecks" };
            
            Console.WriteLine(greeting);
            
            for (var i = 0; i < list.Length; i++) // list length [3] is less than the value of the last element [2] hence the no less-than-euquals
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
