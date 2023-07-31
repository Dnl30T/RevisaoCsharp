using RevisaoCsharp;
using RevisaoCsharp.Apps;

namespace MyApp
{

    /// <summary>
    /// Standard class to summarize learning stuff
    /// </summary>
    class MyProgram
    {
        public static void Main(string[] args) {
            var main = new MyProgram();
			main.Menu();
        }
        public void Menu() {
			string?[] userLog = new string[1];
			string? answer;
			var AppsIndex = new AppsIndex();
			Console.WriteLine("Wich app do you want to start? Insert 0 to exit: ");
			foreach (var item in AppsIndex.getApps()) {
				Console.WriteLine($"{item.Key} - {item.Value}");
			}
			try {
				answer = Console.ReadLine();
				userLog[0] = answer;
				int choice = int.Parse(answer ?? "0");
				switch (choice) {
					case 0:
						break;
					case 1:
						Calculator.Menu();
						break;
					case 2:
						Stopwatch.Menu();
						break;
					case 3:
						TextEditor.Menu();
						break;
					default:
						break;
				}
			}
			catch (Exception) {
				Tools.NonFloatInputError("You should insert a number", userLog);
			}
		}

        struct AppsIndex {
            public Dictionary<int, string> getApps() {
				var My_dict1 = new Dictionary<int, string>();
                My_dict1.Add(1, "Calculator");
				My_dict1.Add(2, "Stopwatch");
				My_dict1.Add(3, "TextEditor");
                return My_dict1;
			}
        }

	}
}