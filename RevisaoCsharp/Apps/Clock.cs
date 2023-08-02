using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoCsharp.Apps {
	public class Clock {

		public static void Menu() {
			while (true) {
				Console.Clear();
				var clock = DateTime.Now;
				Console.WriteLine(String.Format("{0:R}",clock));
				Thread.Sleep(1000);
			}
		}

	}
}
