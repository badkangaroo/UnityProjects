using UnityEngine;
using System.Collections;

public class ArrayLists : MonoBehaviour
{
	public GameObject SpecificObject;
	public GameObject[] AllGameObjects;
	public int[] messyInts = {12,14,6,1,0,123,92,8};
	// Use this for initialization
	void Start()
	{
		//creates an array of an undetermined size and type
		ArrayList aList = new ArrayList(); 
		
		//create an array of all objects in the scene
		Object[] AllObjects = GameObject.FindObjectsOfType(typeof(Object)) as Object[];
		
		//iterate through all objects
		foreach (Object o in AllObjects)
		{
			if (o.GetType() == typeof(GameObject))
			{
				aList.Add(o);
			}
		}
		
		if (aList.Contains(SpecificObject))
		{
			Debug.Log(aList.IndexOf(SpecificObject));
		}

		if (aList.Contains(gameObject))
		{
			aList.Remove(gameObject);
		}
		
		//initialize the AllGameObjects array
		AllGameObjects = new GameObject[aList.Count];
		
		//copy the list to the array
		DistanceComparer dc = new DistanceComparer();
		dc.Target = gameObject;
		aList.Sort(dc);
		
		aList.CopyTo(AllGameObjects);
		ArrayList sorted = new ArrayList();
		sorted.AddRange(messyInts);
		sorted.Sort();
		sorted.Reverse();
		sorted.CopyTo(messyInts);
		

	}
	
	public class DistanceComparer : IComparer
	{
		public GameObject Target;
				
		public int Compare(object x, object y)
		{
			GameObject xObj = (GameObject)x;
			GameObject yObj = (GameObject)y;
			Vector3 tPos = Target.transform.position;
			Vector3 xPos = xObj.transform.position;
			Vector3 yPos = yObj.transform.position;
			float xDistance = (tPos - xPos).magnitude;
			float yDistance = (tPos - yPos).magnitude;
			
			if (xDistance > yDistance)
			{
				return 1;
			} else if (xDistance < yDistance)
			{
				return -1;
			} else
			{
				return 0;
			}
		}
	}
}
