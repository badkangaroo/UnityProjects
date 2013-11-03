using UnityEngine;
using System.Collections;

public class CountdownTimer : BaseTimer {
	
	public override void SetTime ( float t )
	{
		time = t;
	}
	
	public override void BeginTimer( float t )
	{
		endTime = Time.fixedTime + t;	
	}
	
	public override bool Ended ()
	{
		normalizedTime = (endTime-Time.fixedTime) / time;
		return Time.fixedTime >= endTime;
	}
}
