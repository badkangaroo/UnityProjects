using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	public void ParamUsage(int anInt = 1, float anOptionalFloat = 1)
	{
		Debug.Log("using an int " + anInt + " a float? " + anOptionalFloat);
	}
	public void ParamUsage(string words)
	{
		Debug.Log("using a string " + words);
	}
	public void LotsOfParams(int a = 0, int b = 1, int c = 2, int d = 3)
	{
		Debug.Log("a:" + a + "b:" + b + "c:" + c + "d:" + d);
	}

	public GameObject CreateACube(string cubeName, Vector3 position, float scale = 1.0f)
	{
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.name = cubeName;
		cube.transform.position = position;
		cube.transform.localScale = new Vector3(scale, scale, scale);
		return cube;
	}
	public void Variations(ref float a, out float b, float c=10.0f, float d=11.0f)
	{
		b = c / a;
		a = c / d;
	}
//	public void bad( ref int a = 1 ) {
//		Debug.Log ( "test: " + a );
//	}

	void Start()
	{
		CreateACube(scale : 6.0f, cubeName : "henry", position : new Vector3(2.0f, 0, 0));
		LotsOfParams(0, 99);
		LotsOfParams(b: 99);
		LotsOfParams(b: 99, a: 88, d: 777, c: 1234);
		ParamUsage(1);
		ParamUsage(1, 7.0f);
		ParamUsage("not a number");
	}
}