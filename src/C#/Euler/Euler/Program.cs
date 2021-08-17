using System;
using Euler.Question7;
using Euler.Question8;
using Euler.Question9;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We do be running tho");
            
            // Question 7
            //BigPrimeNumber.FindNthPrime(100001);
            
            // Question 8
            // var result8 = LargestProductInASeries.FindLargestProduct(QuestionInput.Question8Input, 13);
            // Console.WriteLine(result8);
            
            //Question 9
            var result9 = SpecialPythagoreanTriplet.CalculateSpecialTriplet(1000);
            Console.WriteLine(result9);
        }
    }
}