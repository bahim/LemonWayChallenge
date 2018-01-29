﻿using System;

namespace ChallengeServiceConsumer
{
    class FiboServiceConsumer : IServiceConsumer
    {
        public void ConsumeService()
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
    }
}
