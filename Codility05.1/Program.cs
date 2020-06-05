/*
Write a function:

class Solution { public int solution(int A, int B, int K); }

that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:

{ i : A ≤ i ≤ B, i mod K = 0 }

For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.

Write an efficient algorithm for the following assumptions:

A and B are integers within the range [0..2,000,000,000];
K is an integer within the range [1..2,000,000,000];
A ≤ B.
*/

using System;

namespace Codility05._1
{
    class Solution
    {
        public int solution(int A, int B, int K)
        {
            int numOfNums = B - A + 1;
            if (K == 1)
                return numOfNums;
            if (A == 0)
            {
                if (B == 0)
                    return 1;
                return (B / K + 1);
            }
            if (A == B)
            {
                if (A % K == 0)
                    return 1;
                return 0;
            }
            int s = numOfNums / K;
            if ((A % K == 0) && (B % K == 0))
                s++;
            if (A < K && B >= K && numOfNums % K > K - A)
                s++;
            return s;
        }
    }

    class Program
    {
        static void Main()
        {
            int max = 2000000000;
            int A = 101;
            int B = 123456789;
            int K = 10000;
            //int A = 11;
            //int B = 345;
            //int K = 17;
            Solution sol = new Solution();
            int s = sol.solution(A, B, K);
            Console.WriteLine("Solution: " + s);
        }
    }
}
