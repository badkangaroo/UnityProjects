using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		GameObject[] gos = GameObject.FindGameObjectsWithTag("Monster");
		ArrayList distances = new ArrayList();
		foreach (GameObject g in gos)
		{
			Vector3 vec = g.transform.position - transform.position;
			float distance = vec.magnitude;
			distances.Add(distance);
		}
		
		float closestValue = (float)distances [0];
		GameObject closestObject = gos [0];
		
		for (int i = 0; i < gos.Length; i++)
		{
			float d = (float)distances [i];
			if (d <= closestValue)
			{
				closestObject = gos [i];
				closestValue = d;
			}
		}
        
		Vector3 up = new Vector3(0, 1, 0);
		Vector3 start = closestObject.transform.position;
		Debug.DrawRay(start, up);
	}
}
