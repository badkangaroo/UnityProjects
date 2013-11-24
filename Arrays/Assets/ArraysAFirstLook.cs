using UnityEngine;
using System.Collections;
public class ArraysAFirstLook : MonoBehaviour
{
	public int[] scores = new int[10];
	public string[] strings = new string[10];
	public float[] floats = new float[10];
	public class MyClass
	{
	}
	public MyClass[] MyClasses = new MyClass[10];
	public GameObject[] MyGameObjects;
	public int ArrayLength;
	public int[] Primes = new int[]{ 1, 3, 5, 7, 11, 13, 17 };
	void Start()
	{
		float[] DynamicFloats = new float[ArrayLength];
		Debug.Log(MyGameObjects.Length);
		for (int i = 0; i < MyGameObjects.Length; i++)
		{
			MyGameObjects [i].name = i.ToString();
		}
		foreach (GameObject go in MyGameObjects)
		{
			Debug.Log(go.name);
		}
		int[] scores = new int[10];
		int s = 0;
		while (s < 10)
		{
			scores [s] = Random.Range(0, 100);
			int score = scores [s]; //getting a value from the array
			print(score);
			s++;
		}
	}
}