using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
//	int a = 8;
//	float b = 7f;
//	//first version of a function
//	int HalfValue(int a)
//	{
//		return a / 2;
//	}
//	//second version of a function
//	float HalfValue(float a)
//	{
//		return a / 2.0f;
//	}
//	int a = 8;
//	float b = 7;
//	
//	int HalfValue(int a)
//	{
//		return a / 2;
//	}
//	
//	int HalfValue(float a)
//	{
//		return (int)a / 2;
//	}
//	int a = 8;
//	float b = 7;
//	
//	int HalfValue(int a)
//	{
//		return a / 2;
//	}
//	
//	int HalfValue(int a)//oops?
//	{
//		return a * 0.5;
//	}
//
//	int RetVal()
//	{
//		return 1;
//	}
//	
//	float RetVal()
//	{
//		return 1.0f;
//	}	
//	void Start()
//	{
//		int a = RetVal();
//		float b = RetVal();
//	}
//	public static int Reloaded()
//	{
//		return 1;
//	}
//	
//	public static int Reloaded(int a)
//	{
//		return 1 + a;
//	}
//	
//	public static float Reloaded(int a, float b)
//	{
//		return a / b;
//	}
//	
//	void Start()
//	{
//		int a = Reloaded();
//		int b = Reloaded(3);
//		float c = Reloaded(3, 2.0f);
//		print(a); //prints 1
//		print(b); //prints 4
//		print(c); //prints 1.5
//	}
//	public static void Reloaded(int a, ref float b)
//	{
//		b = (float)a / 3;
//	}
//	
//	void Start()
//	{
//		float d = 0;
//		Reloaded(1, ref d);
//		System.Console.WriteLine(d);
//	}
//	public static double classInt = 13; // class scoped number
//	
//	public static void Reloaded(double b)
//	{
//		classInt = b;
//	}
//	
//	void Start()
//	{
//		print(classInt); // prints 13
//		Reloaded(9.0); //sets the classInt to 9.0
//		print(classInt); //prints 9
//	}
	GameObject CreateObject()
	{
		GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
		return g;
	}
	
	GameObject CreateObject(PrimitiveType pt)
	{
		GameObject g = GameObject.CreatePrimitive(pt);
		return g;
	}
	
	GameObject CreateObject(PrimitiveType pt, Vector3 loc)
	{
		GameObject g = GameObject.CreatePrimitive(pt);
		g.transform.position = loc;
		return g;
	}
	
	// Use this for initialization
	void Start()
	{
		GameObject a = CreateObject();
		GameObject b = CreateObject(PrimitiveType.Cylinder);
		GameObject c = CreateObject(PrimitiveType.Sphere, new Vector3(2.0f, 3.5f, 1.3f));
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
}
