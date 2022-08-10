using System;
using System.Text;
using ExtensionMethods;

namespace useExtensionMethod
{
    //public static class ExtMethodClass
    //{
    //    public static int ToCurrency(this string str)
    //    {
    //        return Int32.Parse(str);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string :");
            str = Console.ReadLine();
            try
            {
                Int32.TryParse(str, out int numValue);
                    int num = str.ToCurrency();
                    Console.WriteLine("$ {0}", num); 
                
            }
            catch(FormatException e)
            {
                Console.Write(e.GetType());
            }

            Console.ReadLine();
        }
    }
}



