using System;
using System.Linq;
using System.Collections.Generic;

//This Code is need a mono.

namespace LinqCount
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var Check = new CountClass();

			var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

			//奇数を求める
			var coutn1 = Check.Count(numbers, n => n % 2 == 1);
			Console.WriteLine(coutn1);

			//5以上の数をカウントする
			var count2 = Check.Count(numbers, n => n >= 5);
			Console.WriteLine(count2);

			//2以上8未満の数をカウントする
			var count3 = Check.Count(numbers, n => 2 <= n && n < 8);
			Console.WriteLine(count3);

			//数字の1が含まれている数をカウントする
			var count4 = Check.Count(numbers, n => n.ToString().Contains('1') );
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