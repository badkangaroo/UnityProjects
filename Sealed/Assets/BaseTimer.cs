using UnityEngine;
using System.Collections;

public abstract class BaseTimer {
	public float time{get;set;}
	public float endTime{get;set;}
	
	public readonly float remaining;	
	public readonly float normalized;
	public enum TimerPhase {
		starting,
		started,
		counting,
		ending,
		ended
	};
	public readonly TimerPhase phase;
	
	public abstract void SetTime(float t);
	public abstract void End();
	public abstract bool Ended();
	public abstract void Begin(float t);
	public abstract bool counting(float deltaTime);
}
