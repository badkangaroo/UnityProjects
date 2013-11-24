using UnityEngine;
using System.Collections;

public sealed class FinalizedObject : MonoBehaviour
{
	CountdownTimer countdown;
	void Start()
	{
		countdown = new CountdownTimer();
		countdown.SetTime(3.0f);
		countdown.BeginTimer();
	}
	void Update()
	{
		if (countdown.Ended())
		{
			Debug.Log("end");
		}
	}
}
