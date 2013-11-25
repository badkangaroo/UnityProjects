using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	public class MyClass
	{
		private string name;
		public MyClass(string n)
		{
			name = n;
		}
		public MyClass(int n)
		{
			name = n.ToString();
		}
	}

	void Start()
	{
		MyClass mc = new MyClass(3);
	}

}