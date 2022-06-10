using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var arr = new char[9] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            var str = "";

            foreach (char c in arr)
            {
                try
                {
                    str = c.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse item:{c}");
                    
                }
                finally//Cuz why not lol, it has the same result. Just looks nicer I guess.
                {
                    Console.WriteLine(str);
                }
            }


            arr[6] = '7';
            arr[7] = '8';
            arr[8] = '9';

            foreach (char c in arr)
            {
                try
                {
                    str = c.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse item:{c}");

                }
                finally//Cuz why not lol, it has the same result. Just looks nicer I guess.
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}
