using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FibonacciNumberGenerator.Models
{
    public class Result
    {
        public Int64 InputNumber { get; set; }
        //Method to find the nth number of the Fibonacci Sequence
        public Int64 GetFibonacciSequence()
        {
            Int64 previous = 0;
            Int64 next = 1;
            Int64 result = 0;

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