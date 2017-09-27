using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "TV";
            int productYear = 2012;
            double productPrice = 279.99;

            string converted = productYear.ToString();

            int newYear = 2012; //

            //if parse error catch the error 
            try
            {
                newYear = int.Parse(productName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //string message = string.Format("I have a {0} from {1} costing {2}", productName, productYear, productPrice); //C# concatenate string
            //string message2 = string.Format("I have a {0} from {1} costing {2}", productName, converted, productPrice); //C# concatenate string
            string message3 = string.Format("I have a {0} from {1} costing {2}", productName, newYear, productPrice); //C# concatenate string
            //Console.WriteLine(message);
            //Console.WriteLine(message2);
            Console.WriteLine(message3);

            // Console.WriteLine("Product name: " + productName + "\nProduct year: " + productYear + "\nProduct price: " + productPrice); //concatenating

            Console.ReadLine();
        }
    }
}
