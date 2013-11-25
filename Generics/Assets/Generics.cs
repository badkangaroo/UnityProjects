using UnityEngine;
using System.Collections;

public class Generics : MonoBehaviour
{
	void Start()
	{
		
		zombie firstZombie = new zombie("stubbs");
		zombie secondZombie = new zombie("jackson");
		zombie thirdZombie = new zombie("bob");
		var SomeThings =
			new ThreeThings<zombie>(firstZombie, secondZombie, thirdZombie);
		Debug.Log(SomeThings);
		var whatAmI = 1;
		Debug.Log(whatAmI.GetType());
		var mixedThings = new TwoThings<zombie, float>();
		mixedThings.AssignThings(firstZombie, 1.0f);
		LogTwoThings(mixedThings.GetFirstThing(), mixedThings.GetSecondThing());
		var t = GetComponent<Transform>();
		if (t is Transform)
		{
			t.localPosition = new Vector3(1, 0, 0);
		}

	}

	//	void Start()
	//	{
	//		var ImAFloat = tellMeLies(11.8f);
	//		Debug.Log(ImAFloat);
	//	}
	
	
	
	//	void Start()
	//	{
	//		zombie firstZombie = new zombie("stubbs");
	//		zombie secondZombie = new zombie("jackson");
	//		zombie thirdZombie = new zombie("bob");
	//		ThreeThings<zombie> SomeThings =
	//			new ThreeThings<zombie>(firstZombie, secondZombie, thirdZombie);
	//		Debug.Log(SomeThings);
	//	}
	
	//	void Start()
	//	{
	//		zombie first = new zombie("stubbs");
	//		zombie second = new zombie("jackson");
	//		Debug.Log(first);
	//		Debug.Log(second);
	//		swap(ref first, ref second);
	//		Debug.Log(first);
	//		Debug.Log(second);
	//	}
	
	//	void Start()
	//	{
	//		string first = "one";
	//		string second = "two";
	//		Debug.Log(first);
	//		Debug.Log(second);
	//		swap(ref first, ref second);
	//		Debug.Log(first);
	//		Debug.Log(second);
	//	}
	
	//	// Use this for initialization
	//	void Start()
	//	{
	//		int first = 1;
	//		int second = 2;
	//		Debug.Log(first);
	//		Debug.Log(second);
	//		swap(ref first, ref second);
	//		Debug.Log(first);
	//		Debug.Log(second);
	//
	//		log(9);
	//		GameObject g = new GameObject("My name is mud");
	//		log(g);
	//	}
	public void log<T>(T thing)
	{
		string s = thing.ToString();
		Debug.Log(s);
	}

	public void swap<T>(ref T a, ref T b)
	{
		T temp = b;
		b = a;
		a = temp;
	}
	public class zombie
	{
		private string Name;//store the zombies name
		//constructor to assign a name on creation.
		public zombie(string name)
		{
			Name = name;
		}
		//override the ToString() command by
		//returning the zombies name instead of it's type.
		public override string ToString()
		{
			return Name;
		}
	}
	
	public class ThreeThings<T>
	{
		private T first;
		private T second;
		private T third;
		
		//constructor for three things
		public ThreeThings(T a, T b, T c)
		{
			first = a;
			second = b;
			third = c;
		}
		
		//override ToString()
		public override string ToString()
		{
			return first + " " + second + " " + third;
		}
	}
	public int tellMeLies(float f)
	{
		return (int)f;
	}

	public class Stuff<T>
	{
		T thing;
		public void assignThing(T something)
		{
			thing = something;
		}
	}
//	public class TwoThings<T, U>
//	{
//		T firstThing;
//		U secondThing;
//		
//		public void AssignThings(T first, U second)
//		{
//			firstThing = first;
//			secondThing = second;
//		}
//	}

	public void LogTwoThings<T, U>(T firstThing, U secondThing)
	{
		Debug.Log(firstThing.GetType());
		Debug.Log(secondThing.GetType());
	}

	public class TwoThings<T, U>
	{
		T firstThing;
		U secondThing;
		public void AssignThings(T first, U second)
		{
			firstThing = first;
			secondThing = second;
		}
		public T GetFirstThing()
		{
			return firstThing;
		}
		public U GetSecondThing()
		{
			return secondThing;
		}
	}


	
	// Update is called once per frame
	void Update()
	{
		
	}
}