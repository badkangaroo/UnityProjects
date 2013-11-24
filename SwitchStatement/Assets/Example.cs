using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	void Start()
	{
		int i = 3;
		switch (i)
		{
			case 0:
				Debug.Log("i is zero");
				break;
				
			case 1:
				Debug.Log("i is one");
				break;	
		
			case 2:
				Debug.Log("i is two");
				break;
	
			default:
				Debug.Log("Every other number");
				break;
		}
//		bool b = true;
//		switch (b)
//		{
//			case true:
//				print("got true");
//				break;
//			case false:
//				print("got false");
//				break;
//		}
//		float f = 2.0f;
//		switch (f)
//		{
//			case f < 1.0f:
//				Debug.Log("less than 1.0f");
//				break;
//			
//			case f > 3.0f:
//				Debug.Log("more than 3.0f");
//				break;
//			
//			default:
//				Debug.Log("neither case");
//				break;
//		}
		int a = 0;
		int b = 1;
		switch (a)
		{
			case 0:
				switch (b)
				{
					case 1:
						Debug.Log("might not be worth it");
						break;
				}
				break;
		}
	}


	public enum MyCases
	{
		first,
		second,
		third,
		fourth,
		fifth,
		sixth,
		seventh
	}
	
//	public MyCases cases;
//	void Update()
//	{
//		switch (cases)
//		{
//			case MyCases.first:
//				Debug.Log("first case");
//				break;
//			case MyCases.second:
//				Debug.Log("second case");
//				break;
//			case MyCases.third:
//				Debug.Log("third case");
//				break;
//			case MyCases.fourth:
//				Debug.Log("fourth case");
//				break;
//			case MyCases.fifth:
//				Debug.Log("fifth case");
//				break;
//			case MyCases.sixth:
//				Debug.Log("sixth case");
//				break;
//			case MyCases.seventh:
//				Debug.Log("seventh case");
//				break;
//			default:
//				Debug.Log("other case");
//				break;
//		}
//	}

	void Update()
	{
		int a = 0;
		switch (a)
		{
			case 0:
				a = 1;
				FirstFunction(a);
				break;
			
			case 1:
				SecondFunction();
				break;
		}
	}
	
	void FirstFunction(int i)
	{
		switch (i)
		{
			case 0:
				Debug.Log("first case");
				break;
			
			case 1:
				Debug.Log("i was incremented!");
				break;
		}
	}
	
	void SecondFunction()
	{
		Debug.Log("second case");
	}

}
