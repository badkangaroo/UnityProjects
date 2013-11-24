using UnityEngine;
using System.Collections;

public class FPSMove : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
	
	}
	
	// Update is called once per frame
	public float speed = 0.1f;
	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += transform.forward * speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position -= transform.forward * speed;
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.right * speed;
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += transform.right * speed;
		}
	}

}
