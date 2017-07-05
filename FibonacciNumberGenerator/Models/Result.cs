using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FibonacciNumberGenerator.Models
{
    public class Result
    {
        public long InputNumber { get; set; }
        //Method to find the nth number of the Fibonacci Sequence
        public long GetFibonacciSequence()
        {
            long previous = 0;
            long next = 1;
            long result = 0;

            for (int i = 2; i <= InputNumber; i++)
            {
                if (InputNumber <= 1)
                {
                    result = 0;
                }
                else
                {
                    result = previous + next;
                    previous = next;
                    next = result;
                }
            }
            return result;
        }
    }
}