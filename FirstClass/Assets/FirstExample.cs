using UnityEngine;
using System.Collections;
using System.IO;

public class FirstExample : MonoBehaviour
{
		class MyClass
		{
				public int num = 0;
				public void PrintNum ()
				{
						Debug.Log (num);
				}
		}
		class AnotherClass
		{
				public int anotherNum = 1;
				public void PrintNum ()
				{
						Debug.Log (anotherNum);
				}
		}
		void SimpleFunction ()
		{
				Debug.Log ("simple function is being called");
		}

		// Use this for initialization
		void Start ()
		{
				StreamWriter writer = new StreamWriter ("MyFile.txt");
				writer.WriteLine ("im a new text file.");
				writer.Flush ();
				Debug.Log ("Start");
				SimpleFunction ();
				Debug.Log (10 / 3);
				Debug.Log (10.0f / 3.0f);
				Debug.Log (10.0 / 3.0);
				Debug.Log (10000000.0f / 3.0f);
				Debug.Log (1000000000000000.0 / 3.0);
				int a = 1 + 3 * 7 + 9;
				Debug.Log (a);
		}

		// Update is called once per frame
		void Update ()
		{
		
		}
}








