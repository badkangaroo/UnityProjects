using UnityEngine;
using System.Collections;

public abstract class BaseTimer
{
	public float time;
	public float endTime;
	public float remainingTime;
	public float normalizedTime;
	
	public abstract void SetTime(float t);
	public abstract bool Ended();
	public abstract void BeginTimer();
}
