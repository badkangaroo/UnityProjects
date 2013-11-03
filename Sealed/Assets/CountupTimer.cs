using UnityEngine;
using System.Collections;

public class CountupTimer : BaseTimer {
	
	public override void SetTime (float t)
	{
		time = t;
	}
	
	public override void BeginTimer ()
	{
		endTime = Time.fixedTime - time;	
	}
	
	public override bool Ended ()
	{
		normalizedTime = endTime / time;
		return Time.fixedTime < endTime;
	}
}
