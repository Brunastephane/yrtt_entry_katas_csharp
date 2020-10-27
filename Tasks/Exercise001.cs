using System;
using System.Collections.Generic;
using System.Linq;

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace TechReturners.Tasks
{
    public class Exercise001
    {
        public static int Singles(List<int> source)
        {
            //variable for sum the numbers 
            int result = 0;

            //This loop is getting every single number from source until the end of the list
            foreach (int item in source)
            {
                //I`ve used linq expressions to avoid created other loop and other variables
                //This If checks how quantity of times that number appears on the list and if is just once it will sum
                if(source.Where(n => n == item).Count() == 1)
                {
                    //add the value on the variable result 
                    result = result + item;
                }
            }
            //return the sum
            return result;
            throw new NotImplementedException();
        }
    }
}