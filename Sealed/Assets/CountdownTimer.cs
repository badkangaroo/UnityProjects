using UnityEngine;
using System.Collections;

public class CountdownTimer : BaseTimer {
	
	public override void SetTime (float t)
	{
		time = t;
	}
	
	public override void BeginTimer ()
	{
		endTime = Time.fixedTime + time;	
	}
	
	public override bool Ended ()
	{
		normalizedTime = (endTime-Time.fixedTime) / time;
		return Time.fixedTime >= endTime;
	}
}
