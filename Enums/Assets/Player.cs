using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public float Speed = 0.1f;

	// Update is called once per frame
	void Update()
	{
		gameObject.transform.position += Movement(Speed);
	}
	Vector3 Movement(float dist)
	{
		Vector3 vec = Vector3.zero;
		if (Input.GetKey(KeyCode.A))
		{
			vec.x -= dist;
		}
		if (Input.GetKey(KeyCode.D))
		{
			vec.x += dist;
		}
		if (Input.GetKey(KeyCode.W))
		{
			vec.z += dist;
		}
		if (Input.GetKey(KeyCode.S))
		{
			vec.z -= dist;
		}
		return vec;
	}
}
