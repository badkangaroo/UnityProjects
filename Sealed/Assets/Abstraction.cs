using UnityEngine;
using System.Collections;

public abstract class Abstraction : MonoBehaviour
{
	abstract class BaseClass
	{
		public int Counter;
		public abstract void ImportantFunction();
	}
	
	abstract class SecondaryClass : BaseClass
	{
		public int Limit;
		public abstract bool AtLimit();
		public abstract void SetLimit(int l);
	}

	sealed class ChildClass : SecondaryClass
	{		
		public override void ImportantFunction()
		{
			Counter++;
			Debug.Log(Counter);
		}
		
		public override bool AtLimit()
		{
			return Counter >= Limit;
		}
		
		public override void SetLimit(int l)
		{
			Limit = l;
		}
	}


//	// Use this for initialization
//	void Start()
//	{
//		ChildClass c = new ChildClass();
//		c.SetLimit(2);
//		c.ImportantFunction(); // prints 1
//		Debug.Log(c.AtLimit());//prints False
//		c.ImportantFunction(); // prints 2
//		Debug.Log(c.AtLimit()); //prints True
//	}
//	
//	// Update is called once per frame
//	void Update()
//	{
//	
//	}

}
