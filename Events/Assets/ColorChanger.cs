using UnityEngine;
using System.Collections;
using System;

public class ColorChanger : EventListener
{
	public Color CloseColor;
	public Color FarColor;
	
	public override void ProximityEvent(object sender, EventArgs e)
	{
		Transform t = sender as Transform;
		Vector3 targetVector = t.position - transform.position;
		float distanceToTarget = targetVector.magnitude;

		if (distanceToTarget > 10)
		{
			gameObject.GetComponent<Light>().color = CloseColor;
		} else
		{
			gameObject.GetComponent<Light>().color = FarColor;
		}
		Debug.Log(distanceToTarget);
	}
}