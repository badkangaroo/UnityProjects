using UnityEngine;
using System.Collections;

public class FPSAim : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	float mouseX;
	float mouseY;
	public bool InvertedMouse;
	void Update()
	{
		//Vector3 mousePosition = Input.mousePosition;
		//Debug.Log(mousePosition);
		//float mouseX = mousePosition.x;
		//float mouseY = mousePosition.y;
		//transform.eulerAngles = new Vector3(mouseY * 0.1f, 0, 0);
		mouseX += Input.GetAxis("Mouse X");
		if (InvertedMouse)
		{
			mouseY += Input.GetAxis("Mouse Y");
		} else
		{
			mouseY -= Input.GetAxis("Mouse Y");
		}
		Debug.Log(mouseX);
		transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
	}
}
