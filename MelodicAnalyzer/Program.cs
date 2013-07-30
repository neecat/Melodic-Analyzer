using System;

namespace MelodicAnalyzer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Version Variable
			string version = "1.0m";
			string filepath; // File Path Catcher

			Console.WriteLine ("Melodic Analyzer " +version);
			Console.WriteLine ("By: Nathanial Karahalis");
			Console.WriteLine ("Translated to C#");
			Console.Write ("\n\nWhere would you like to save the file?(*.csv): ");
			filepath = Console.ReadLine ();

		}
	}
}
