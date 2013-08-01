using System;
using System.IO;

namespace MelodicAnalyzer
{
	public class Sequence
	{
		//Class Variables
		//modification: addition of float vars - April 9th, 2013 - 10:18:00 EDT
		//Associate Letters and Sharps to floating decimal numberss

		//modification: translated to C# and moved into a class - July 30, 2013 - 06:51:00 EDT
		string[] natnoteletters = { "C", "D", "E", "F", "G", "A", "B" };
		float[] natural={1.0f,2.0f,3.0f,3.5f,4.5f,5.5f,6.5f};

		string[] sharpnoteletters={"B#","C#","D#","E#","F#","G#","A#"};
		float[] sharp={1.0f,1.5f,2.5f,3.5f,4.0f,5.0f,6.0f};

		string[] flatnoteletters={"Db","Eb","Fb","Gb","Ab","Bb","Cb"};
		float[] flat={1.5f,2.5f,3.5f,4.0f,5.0f,6.0f,6.5f};

		int notestotal=0;
		int currentnote=0;
		string[] userinput;
		float[] durations;
		public Sequence (int numberofnotes)
		{
			notestotal = numberofnotes;
		}

		public void poll()
		{
			string note;
			float notelength;
			Console.Write ("What note would you like to add?: ");
			note = Console.ReadLine ();
			Console.Write ("What length is it?(in 8th notes): ");
			notelength = Console.ReadLine ();
			addNote (note, notelength); 
		}

		public void addNote(string note,float duration)
		{
			/* Need to make sure to add something that will separate
			 * the note letter from the octave modifier.
			 * Also, there needs to be an octave modifier...
			 */
			userinput [currentnote] = note;
			durations [currentnote] = duration;
			currentnote++;
		}
		public float[] analyze(string[] sequ,int numberofnotes)
		{
			float[] output=new float[numberofnotes];
			for (int x=0; x<sequ.Length; x++) {
				for (int n=0; n<natural.Length; n++) {
					try{
						if (sequ [x] == sharpnoteletters [x]) {
							output [x] = sharp [x];
							break;
						}
						if (sequ [x] == flatnoteletters [x]) {
							output [x] = flat [x];
							break;
						}
						if (sequ [x] == natnoteletters [x]) {
							output [x] = natural [x];
							break;
						}
					}catch(IndexOutOfRangeException e) {
						Console.Write ("Error: Out of range!\n" + e.Message);
					}
				}
			}
			 return output;
		}
	}
}

