using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoCsharp {
	internal class Tools {
		/// <summary>
		/// Error caused by inserting a non number into number field
		/// </summary>
		/// <param name="error"></param>
		/// <param name="log"></param>
		public static void NonFloatInputError(string error, string?[] log) {
			Console.WriteLine(error);
			Console.WriteLine("Log:");
			foreach (var input in log) {
				if (float.TryParse(input, out _) == false) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(input);
					Console.ResetColor();
				}
				else {
					Console.WriteLine(input);
				}

			}
			//Yes, i lied
			Console.WriteLine("Returning to menu in 10 seconds");
			Thread.Sleep(8000);
		}
	}
}
