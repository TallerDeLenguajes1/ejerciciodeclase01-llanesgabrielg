using System;

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[5];
            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
