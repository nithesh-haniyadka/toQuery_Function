//using Extensions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;


//namespace ExtendingStrings
//{


//    class Program
//    {

//        public static class ExtMetClass
//        {
//            public static int IntegerExtension(this string str)
//            {
//                return Int32.Parse(str);
//            }
//        }
//        static void Main(string[] args)
//        {
//            string test;
//            Console.WriteLine("Enter the string :");
//            test = Console.ReadLine();
//            int num = test.IntegerExtension();
//            //l = findLength(test);

//            //Console.Write("Length of the string is : {0}\n\n", l);





//            //if (test.IsInteger())
//            //{
//            //    Console.WriteLine("value = {0}", test.IsInteger());
//            //}


//            Console.ReadLine();
//        }

//    }

//}
using System;
using System.Text;
namespace ExtensionMethod2
{
    public static class ExtMetClass
    {
        public static int ToCurrency(this string str)
        {
            return Int32.Parse(str);
        }
    }

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



