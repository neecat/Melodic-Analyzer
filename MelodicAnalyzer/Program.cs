using System;
using System.IO;

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
			//Try to open the file
			try{
				FileStream csv = File.Open (filepath,FileMode.Create);
			} catch(FileNotFoundException e) {
				Console.WriteLine ("Unable to create file");
				Console.Write ("Exception: "+e.Message);
				Environment.Exit (1);
			}

		}
	}
}
