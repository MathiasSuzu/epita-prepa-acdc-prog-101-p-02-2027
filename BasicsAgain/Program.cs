using System;
using BasicsAgain;

namespace Basics
{
	internal static class Program
	{
		static void Main(string[] args)
		{
			/*int[][] r = Advanced.Levenshtein("niche", "chien");
			for (int i = 0; i < r.Length; i++)
			{
				foreach (int VARIABLE in r[i])
				{
					Console.Write(VARIABLE);
					Console.Write(" ");
				}
				Console.WriteLine();
			}*/
			/*string str1 = "Pneumonoultramicroscopicsilicovolcanoconiosis";
			string str2 = "Hippopotomonstrosesquippedaliophobia";
				Console.WriteLine(Advanced.Levenshtein(str1, str2));*/
			
			int[][] map =
			{
				new[] { 0, 1, 1, 1, 0, 1, 0, 0 },
				new[] { 0, 1, 0, 1, 0, 0, 1, 1, 1 },
				new[] { 0, 0, 1, 0, 0, 1, 0 },
				new[] { 0, 1, 0, 1, 0, 0, 0, 0, 1 },
				new[] { 0, 1, 1, 1, 1, 0, 1, 0 },
				new[] { 1, 1, 0, 1, 0, 0, 0, 0, 1 }
			};
			
			Console.WriteLine(Hard.CountTowns(map));
		}
	}
}
