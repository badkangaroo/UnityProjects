using UnityEngine;
using System.Collections;
using System.IO;

public class ReadFromFile : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		//text you want to write
		string strStat = "str 10\n"; //strength
		string dexStat = "dex 12\n"; //dexterity
		string adjStat = "adj 6\n"; //adjility

		//make a text writer
		TextWriter tw = new StreamWriter ("stats.txt");

		//write the text
		tw.Write (strStat);
		tw.Write (dexStat);
		tw.Write (adjStat);

		//clean up
		tw.Close ();

		//make a text reader
		TextReader tr = new StreamReader ("stats.txt");

		//ask the reader to read a line
		string line = tr.ReadToEnd ();
		string[] lines = line.Split ('\n'); // split lines with \n

		foreach (string stat in lines) {
			//break apart with spaces
			// this turns the line which looks like 'str 10' into
			// two strings one that's str and the other is 10
			// so you'll have two things in the array
			string[] values = stat.Split (' '); 

			// if there's actually two things
			// then look at each one and assume the
			// second string is a number
			if (values.Length > 1) {
				// this could be str dex or adj
				string attrib = values [0];

				//make a place to get a number from the string
				int value = 0;
				//get that number
				int.TryParse (values [1], out value);

				//check for strength dexterity and adjility
				if (string.Compare ("str", values [0]) == 0) {
					Debug.Log ("got strength: " + value);
				}

				if (string.Compare ("dex", values [0]) == 0) {
					Debug.Log ("got dexterity: " + value);
				}

				if (string.Compare ("adj", values [0]) == 0) {
					Debug.Log ("got adjility: " + value);
				}

			}
		}

		//clean up
		tr.Close ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
