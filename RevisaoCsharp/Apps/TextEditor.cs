using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RevisaoCsharp.Apps {
	class TextEditor {

		public static void Menu(string? path = null) {
			var editor = new TextEditor();
			Console.Clear();
            if (path != null)
				Console.WriteLine($"File path: {path}");
            Console.WriteLine("O que deseja fazer? \n" +
				"1 - Read\n" +
				"2 - Edit\n" +
				"3 - Create\n" +
				"0 - sair");
			short option = short.Parse(Console.ReadLine() ?? "0");
			switch (option) {
				case 0:
					System.Environment.Exit(0);
					break;
				case 1:
					editor.Read();break;
				case 2:
					editor.Edit(path);	break;
				case 3:
					editor.Create(); break;
				default: 
					Menu(); break;
			}
		}
		protected void Create() {
			Console.WriteLine("Input your file name: ");
			string path = @"E:\Work\C#\RevisaoCsharp\RevisaoCsharp\Apps\AppsFiles\" + 
				(Console.ReadLine() ?? "newFile") + ".txt";
			FileStream fs = File.Create(path);
			Console.WriteLine("Do you want to attach this file to the editor? [Y]/n");
			string choice = (Console.ReadLine() ?? "n").ToLower();
			switch (choice) {
				case "n":
					Menu(); break;
				case "y":
					Menu(path); break;
				default : Menu(); break;
			}
		}
		protected void Read() {
			Console.WriteLine("Enter the file path: ");
			string path = Console.ReadLine() ?? "null";
			Console.WriteLine("path saved");
			Thread.Sleep(2000);
			Menu(path);
		}
		protected void Edit(string? path = null) {
			if (path == null) {
				Console.WriteLine("you did not input a valid file path \n" +
					$"Current file path: {path}");
				Thread.Sleep(2000);
				Menu();
			}
			Console.Clear();
			Console.WriteLine("Input your text here, press (esc) to exit:\n" +
				"------------------------------------");
			string text = "";
			do {
				text += Console.ReadLine();
				text += Environment.NewLine;
			}
			while (Console.ReadKey().Key != ConsoleKey.Escape);

			using (var file = new StreamWriter(path ?? "")) {
				file.Write(text);
			}

			Console.WriteLine(text);
			Menu(path);
		}

	}
}
