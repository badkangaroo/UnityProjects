using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	void Start()
	{
		Toaster T = new Toaster();
		T.ThingName = "Talkie";
		print(T.ThingName);
		Zombie Z = (Zombie)gameObject.AddComponent<Zombie>();
		Z.ThingName = "Stubbs";
		print(Z.ThingName);
	}

	// Update is called once per frame
	public GameObject[] SortedByDistance;
	void Update()
	{
		ArrayList ObjectList = new ArrayList();
		GameObject[] Objects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject go in Objects)
		{
			ObjectList.Add(go);
		}
		DistanceComparer dComparer = new DistanceComparer();
		dComparer.Target = this.gameObject;
		ObjectList.Sort(dComparer);
		SortedByDistance = new GameObject[ObjectList.Count];
		ObjectList.CopyTo(SortedByDistance);
	}
}
