using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber.Palindrome
{
    public sealed class PalindromeChecker
    {
        public bool IsPalindrome(int numberToCheck)
        {
            if (numberToCheck < 0) return false;
            var numberArray = numberToCheck.ToString().ToCharArray();
            for (var i = 0; i < numberArray.Length / 2; i++)
            {
                if (numberArray[i] != numberArray[numberArray.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
