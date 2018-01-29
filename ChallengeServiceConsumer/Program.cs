using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeServiceConsumer
{
    class Program
    {
        static public void fibonacciServiceConsumer()
        {
            var client = new ChallengeServiceReference.ServiceSoapClient();
            int nbr;

            while (true)
            {
                Console.WriteLine("----------------------");
                Console.Write("Enter the Nth fibonacci number to find : ");
                var a = Console.ReadLine();

                var isSuccess = int.TryParse(a, out nbr);
                Console.WriteLine("Fibonacci number at position " + a + " is " + client.Fibonacci(nbr));
            }
        }

        static void Main(string[] args)
        {
            fibonacciServiceConsumer();
        }
    }
}
