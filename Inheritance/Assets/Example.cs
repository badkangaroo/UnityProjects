using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	public GameObject ChildObject;
	// Use this for initialization
	void Start()
	{
		PianoCat famousCat = new PianoCat();
		famousCat.PlayPiano();
		famousCat.Meow();
		Debug.Log(famousCat.Paws);
		GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		GameObject[] obs = Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject go in gos)
		{
			Debug.Log(go);
			Component comp = go.GetComponent(typeof(Child));
			if (comp != null)
			{
				ChildObject = go;
			}
		}
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}

	class Cat
	{
		public int Paws = 4;
		public void Meow()
		{
			print("Meow");
		}
	}

	class PianoCat : Cat
	{
		public void PlayPiano()
		{
			Meow();
		}
	}
}
