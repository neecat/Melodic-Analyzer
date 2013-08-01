using System;
using System.IO;
/*
 * Melodic Analyzer Console
 * By Nathanial Karahalis
 * Originally Coded in C
 * Translated and Cleaned up in C#
 * 
 * Description: This program will take a sequence of pitches typed in by the user and will output
 * 				numeric values to a CSV file which can be used in a spreadsheet program to map(chart)
 * 				melodic contour. The resulting graph can be useful in Musical Analysis.
 */
namespace MelodicAnalyzer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Version Variable
			string version = "1.0m";
			string filepath; // File Path Catcher
			int numberofnotes=0;

			//Console Splash
			Console.WriteLine ("Melodic Analyzer " +version);
			Console.WriteLine ("By: Nathanial Karahalis");
			Console.WriteLine ("Translated to C#");

			//Ask where to put the file.
			Console.Write ("\n\nWhere would you like to save the file?(*.csv): ");
			filepath = Console.ReadLine ();

			//Try to open the file
			try{
				FileStream csv = File.Open (filepath,FileMode.Create);
			} catch(FileNotFoundException e) {
				/*If file can't be opened
				 * print the error message stating why
				 */
				Console.WriteLine ("Unable to create file");
				Console.Write ("Exception: "+e.Message);
				Environment.Exit (1);
			}
			Console.Write("\nHow many notes are there?: ");
			numberofnotes=Console.Read();
			for(int x=0; x<(numberofnotes-1); x++)
			{
				//collect function collecting userinput
			}

		}
	}
}
