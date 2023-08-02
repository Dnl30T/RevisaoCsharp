using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RevisaoCsharp.Apps {
	class TextEditor {

		static string? path;

		public static void Menu() {
			var editor = new TextEditor();
			Console.Clear();
            if (path != null)
				Console.WriteLine($"File path: {path}");
            Console.WriteLine("O que deseja fazer? \n" +
				"1 - Find\n" +
				"2 - Edit\n" +
				"3 - Create\n" +
				"4 - Read\n" +
				"0 - sair");
			short option = short.Parse(Console.ReadLine() ?? "0");
			switch (option) {
				case 0:
					System.Environment.Exit(0);
					break;
				case 1:
					editor.Find();break;
				case 2:
					editor.Edit();	break;
				case 3:
					editor.Create(); break;
				case 4:
					editor.Read(); break;
				default: 
					Menu(); break;
			}
		}
		protected void Create() {
			Console.WriteLine("Input your file name: ");
			string path = @"E:\Work\C#\RevisaoCsharp\RevisaoCsharp\Apps\AppsFiles\" + 
				(Console.ReadLine() ?? "newFile") + ".txt";
			using (FileStream fs = File.Create(path)) {
				fs.Close();
			}
			Console.WriteLine("Do you want to attach this file to the editor? [Y]/n");
			string choice = (Console.ReadLine() ?? "n").ToLower();
			TextEditor.path = path;
			switch (choice) {
				case "n":
					Menu(); break;
				case "y":
					Menu(); break;
				default : Menu(); break;
			}
		}
		protected void Find() {
			Console.WriteLine("Enter the file path: ");
			string path = Console.ReadLine() ?? "null";
			TextEditor.path = path;
			Console.WriteLine("path saved");
			Thread.Sleep(2000);
			Menu();
		}
		protected void Edit() {
			if (path == null || !File.Exists(path)) {
				Console.WriteLine("you did not input a valid file path \n" +
					$"Current file path: {path}");
				Thread.Sleep(2000);
				Menu();
			}
			else {
				Console.Clear();
				Console.WriteLine("Input your text here, input (esc) to exit:\n" +
					"------------------------------------");
				string text = "";
				do {
					string input = Console.ReadLine() ?? "";
					if (input == "esc")
						break;
					text += input + Environment.NewLine;
				}
				while (true);

				using (var file = new StreamWriter(path ?? "")) {
					file.Write(text);
				}

				Console.WriteLine(text);
				Menu();
			}
		}
		protected void Read() {
			if (!File.Exists(path)) {
				Console.WriteLine("First, input a valid file path");
			}
			else {
				Console.WriteLine("------------------------------------");
				using (var sr = new StreamReader(path)) {
					string text = sr.ReadToEnd();
					Console.WriteLine(text);
				}
				Console.WriteLine("------------------------------------");
			}
			Console.WriteLine("press enter to proceed");
			Console.ReadKey();
			Menu();
		}

	}
}
