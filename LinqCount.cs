using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqCount
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Check = new CountClass();

            var numbers = new[] { 1,  2,  3,  4,  5,  6,  7,  8,  9, 10,
                                 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                                 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};

            // Find an odd number
            var coutn1 = Check.Count(numbers, n => n % 2 == 1);
            Console.WriteLine(coutn1);

            // Count the number of 5 or more
            var count2 = Check.Count(numbers, n => n >= 5);
            Console.WriteLine(count2);

            // Count the number between 13 and 28
            var count3 = Check.Count(numbers, n => 13 <= n && n < 28);
            Console.WriteLine(count3);

            // Count the number of numbers that contain the number 2
            var count4 = Check.Count(numbers, n => n.ToString().Contains('2'));
            Console.WriteLine(count4);
        }
    }

    class CountClass
    {
        public int Count(int[] numbers, Predicate<int> judge)
        {
            int count = 0;

            foreach (var n in numbers)
            {
                if (judge(n) == true)
                    count++;
            }

            return count;
        }
    }
}


// ===== Output Sample =====

// ~/LinqCount $ mcs LinqCount.cs 
// ~/LinqCount $ mono ./LinqCount.exe 
// 15
// 26
// 15
// 12

// =========================
