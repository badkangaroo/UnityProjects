using UnityEngine;
using System.Collections;
using System;

public class EventListener : MonoBehaviour
{
	public bool isClose;

	// Use this for initialization
	void Start()
	{
		EventDispatcher dispatcher =
			GameObject.Find("Main Camera").GetComponent<EventDispatcher>();
		dispatcher.ProperEvent += ProximityEvent;
	}

	public virtual void ProximityEvent(object sender, EventArgs e)
	{
		Transform t = sender as Transform;
		Vector3 targetVector = t.position - transform.position;
		float distanceToTarget = targetVector.magnitude;

		if (distanceToTarget > 10)
		{
			gameObject.GetComponent<Light>().intensity = 1.0f;
		} else
		{
			gameObject.GetComponent<Light>().intensity = 3.0f;
		}
		Debug.Log(distanceToTarget);
	}
	
	void OnDestroy()
	{
		EventDispatcher dispatcher =
			GameObject.Find("Main Camera").GetComponent<EventDispatcher>();
		dispatcher.ProperEvent -= ProximityEvent;
	}
}
