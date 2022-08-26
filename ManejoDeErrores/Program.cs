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
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
                
            }
            catch (System.Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("aqui va el mensaje de error: desbordamiento del vector " + ex.Message);
                //Console.WriteLine("aqui va el mensaje de error : desbordamiento de vector ");
            }
            //Console.ReadLine();
        }
    }
}


