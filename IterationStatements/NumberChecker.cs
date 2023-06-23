using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    public class NumberChecker
    {
        public static int TakeTwoNums(int num1, int num2)
            => num1 > num2 ? num1 : num2;

        public static string IsEvenOrOdd(int num1)        
            => (num1 % 2 == 0) ? "is even." : "is odd.";
                    
        public static string IsPositive(int num1)
            => num1 > 0 ? "is positive." : "is negative.";

        public static string IsOldEnough(int num1)
            => num1 > 18 ? "is old enough." : "is not old enough.";


        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static string isBetweenN10P10(int num1)
            => num1 <= 10 && num1 >= -10 ?
            $"{num1} is between -10 and 10." :
            $"{num1} is not between -10 and 10.";
    

    }
}
