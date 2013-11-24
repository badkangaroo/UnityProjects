using UnityEngine;
using System.Collections;
public class DistanceComparer : IComparer
{
	public GameObject Target;
	
	public int Compare(object x, object y)
	{
		GameObject xObj = (GameObject)x;
		GameObject yObj = (GameObject)y;
		Vector3 tPos = Target.transform.position;
		Vector3 xPos = xObj.transform.position;
		Vector3 yPos = yObj.transform.position;
		float xDistance = (tPos - xPos).magnitude;
		float yDistance = (tPos - yPos).magnitude;
		
		if (xDistance > yDistance)
		{
			return 1;
		} else if (xDistance < yDistance)
		{
			return -1;
		} else
		{
			return 0;
		}
	}
}
