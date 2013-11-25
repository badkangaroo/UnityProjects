using UnityEngine;
using System.Collections;
using System;

public delegate void ProperEventHandler(object sender,EventArgs e);

public class EventArgs<T> : EventArgs
{
	public EventArgs(T v)
	{
		Value = v;
	}

	public T Value;
}

public class EventDispatcher : MonoBehaviour
{
	
	public event ProperEventHandler ProperEvent;
	
	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void Update()
	{
		GameObject[] Lights =
			GameObject.FindGameObjectsWithTag("Lights") as GameObject[];
		foreach (GameObject l in Lights)
		{
			Vector3 targetVector =
				l.transform.position - transform.position;
			float distanceToTarget =
				targetVector.magnitude;
			EventListener el = l.GetComponent<EventListener>();
			if (distanceToTarget <= 10 && !el.isClose)
			{
				ProperEvent(gameObject.transform,
				            new EventArgs<float>(distanceToTarget));
				el.isClose = true;
			}
			
			if (distanceToTarget > 10 && el.isClose)
			{
				ProperEvent(gameObject.transform,
				            new EventArgs<float>(distanceToTarget));
				el.isClose = false;
			}
		}
	}
}
