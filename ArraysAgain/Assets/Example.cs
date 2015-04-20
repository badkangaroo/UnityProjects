using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	public int numBoxes = 10;
	public GameObject[] boxes;
	public float spacing;
//	public GameObject[] boxes = new GameObject[10];
//	public GameObject box1;
//	public GameObject box2;
//	public GameObject box3;
//	public GameObject box4;
//	public GameObject box5;
//	public GameObject box6;
//	public GameObject box7;
//	public GameObject box8;
//	public GameObject box9;
//	public GameObject box10;

	//a single int
	int MyInt;
	
	//an array of ints
	int[] MyInts;
	
	//a single object
	object MyObject;
	
	//an array of objects
	object[] MyObjects;

	// Use this for initialization
	void Start()
	{
		boxes = new GameObject[numBoxes];
		for (int i = 0; i < numBoxes; i++)
		{
			GameObject box =
				GameObject.CreatePrimitive(PrimitiveType.Cube);
			//box.AddComponent("Monster");
			Monster m = box.AddComponent<Monster>() as Monster;
			//Monster m = box.GetComponent("Monster") as Monster;
			m.ID = i;
			boxes [i] = box;
		}
	}
	
	// Update is called once per frame
	void Update()
	{
		int i = 0;
		foreach (GameObject go in boxes)
		{
			//			go.transform.position = new Vector3(i * 1.0f, 0, 0);
			float wave = Mathf.Sin(Time.fixedTime + i);
			go.transform.position = new Vector3(i * spacing, wave, 0);
			i++;
			print(i);
		}
	}
}
