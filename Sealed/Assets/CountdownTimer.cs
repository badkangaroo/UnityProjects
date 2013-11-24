using UnityEngine;
using System.Collections;

public class CountdownTimer : BaseTimer
{
	public override void BeginTimer()
	{
		endTime = Time.fixedTime + time;
	}
	public override bool Ended()
	{
		return Time.fixedTime >= endTime;
	}
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
	public override void SetTime(float t)
	{
		time = t;
	}
	public override string ToString()
	{
		return string.Format("[CountdownTimer]");
	}
}
