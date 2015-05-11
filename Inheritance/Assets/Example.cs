using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	public GameObject ChildObject;
	//	As appears in 5.3.4

	//	Use this for initialization	
	//	void Start ()
	//	{
	//		PianoCat famousCat = new PianoCat();
	//		famousCat.PlayPiano();
	//		famousCat.Meow();
	//		Debug.Log(famousCat.Paws);
	//		GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
	//		foreach (GameObject go in gos)
	//		{
	//			Debug.Log(go);
	//			Component comp = go.GetComponent(typeof(Child));
	//			//it's mentioned but, we should iterate, if the
	//			//comp isn't actually on the game object go, we
	//			//are assigning null to comp!
	//		}
	//	}

	//	As appears in 5.3.5
	
	//	Use this for initialization
	//	void Start ()
	//	{
	//		PianoCat famousCat = new PianoCat();
	//		famousCat.PlayPiano();
	//		famousCat.Meow();
	//		Debug.Log(famousCat.Paws);
	//		GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
	//		foreach (GameObject go in gos)
	//		{
	//			Debug.Log(go);
	//			Component comp = go.GetComponent(typeof(Child));
	//			if( comp != null )
	//			{
	//				ChildObject = go;
	//			}
	//		}
	//	}

	//Use this for initialization
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
