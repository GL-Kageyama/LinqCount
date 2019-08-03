using System;
using System.Linq;
using System.Collections.Generic;

//This Code is need a mono.

namespace LinqList
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var List = new ListClass();

			List.FindLength();

			List.ExistsS();

			List.FindIndexIwate();

			List.FindAllFive();

			List.RemoveHi();

			// RemoveHi関数で除外しているため、リストの数は変わっている
			List.FindIndexIwate();

			List.ForeachConsole();

			// 出力が小文字になるだけで、リストそのものは小文字にならない
			List.ConvertAllString();

			Console.WriteLine();

			List.ForeachConsole();
			
		}
	}

	class ListClass
	{
		List<string> list = new List<string>
		{
			"Tokyo", "Saitama", "Tochigi", "Ibaraki", "Gunma", "Chiba", "Kanagawa", 
			"Shizuoka", "Shiga", "Nagano", "Yamaguchi", "Kouchi", "Aomori", "Iwate", 
		};         

		// 文字数が6の県名を抽出
		public void FindLength()
		{
			var name = list.Find(s => s.Length == 6);
			Console.WriteLine(name);
			Console.WriteLine();
		}

		// 頭文字がSの県名が、あるorない
		public void ExistsS()
		{
			var exists = list.Exists(s => s[0] == 'S');
			Console.WriteLine(exists);
			Console.WriteLine();
		}

		// 岩手県の格納インデックス数を取得
		public void FindIndexIwate()
		{
			int index = list.FindIndex(s => s == "Iwate");
			Console.WriteLine(index);
			Console.WriteLine();
		}

		// 文字数が5文字の県名を取得
		public void FindAllFive()
		{
			var names = list.FindAll(s => s.Length <= 5);
			foreach (var s in names)
				Console.WriteLine(s);
			Console.WriteLine();
		}

		// hiの文字列が入っている県名を除外し、削除した数を取得
		public void RemoveHi()
		{
			var removeCount = list.RemoveAll(s => s.Contains("hi"));
			Console.WriteLine(removeCount);
			Console.WriteLine();
		}

		// リストの各要素を出力
		public void ForeachConsole()
		{
			list.ForEach(s => Console.WriteLine(s));
			Console.WriteLine();
		}

		// 小文字に変換
		public void ConvertAllString()
		{
			var lowerList = list.ConvertAll(s => s.ToLower());
			lowerList.ForEach(s => Console.WriteLine(s));
		}

	}
}





















