using System;

namespace ChallengeServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumer = new FiboServiceConsumer();

            consumer.ConsumeService();
        }
    }
}
