using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeLib
{
    public class Fibonacci
    {
        private readonly int _sequenceSizeMax;

        public Fibonacci(int sequenceSizeLimit)
        {
            if (sequenceSizeLimit <= 0)
                throw new ArgumentException("Fibonacci sequence limit can not be lower than 1");

            _sequenceSizeMax = sequenceSizeLimit;
        }

        public int Compute(int fiboNbrPosition)
        {
            var CurrentFiboNbr = 1;
            var prevFiboNbr = 0;
            var tmp = 0;

            if (fiboNbrPosition < 1 || fiboNbrPosition > _sequenceSizeMax)
                throw new ArgumentException("Fibonacci position number must be between 1 and sequence size limit");

            for (int i = 1; i < fiboNbrPosition; i++)
            {
                tmp = prevFiboNbr;
                prevFiboNbr = CurrentFiboNbr;

                //try
                //{
                CurrentFiboNbr = /*checked(*/CurrentFiboNbr + tmp/*)*/;

                //}
                //catch (OverflowException exception)
                //{
                //    Console.Error.WriteLine(exception);
                //    return -1;
                //}
            }

            return CurrentFiboNbr;
        }
    }
}
