using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FibonacciNumberGenerator.Models
{
    public class Result
    {
        public int InputNumber { get; set; }
        //Method to find the nth number of the Fibonacci Sequence
        public int GetFibonacciSequence()
        {
            int previous = 0;
            int next = 1;
            int result = 0;

            for (int i = 3; i <= InputNumber; i++)
            {
                if (InputNumber <= 1)
                {
                    result = InputNumber;
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