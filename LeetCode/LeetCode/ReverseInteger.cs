using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
*/
namespace LeetCode
{
    class ReverseInteger
    {
        public int Reverse(int x)
        {

            int rev = 0;


            while (x != 0)
            {
                int i = x % 10;
                x = x / 10;

                if ((rev > Int32.MaxValue / 10 || rev == Int32.MaxValue / 10 && i > Int32.MaxValue % 10) || (rev < Int32.MinValue / 10 || rev == Int32.MinValue / 10 && i < Int32.MinValue % 10))
                {
                    rev = 0;
                    break;
                }
                else
                {
                    rev = rev * 10 + i;
                }
            }

            return rev;

        }
    }
}
