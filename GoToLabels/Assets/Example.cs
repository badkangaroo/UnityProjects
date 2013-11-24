using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	public int num = 1;
	
	void Start()
	{
		if (num > 0)
		{
			goto MyLabel; // goes to MyLabel
		}
		
		print("number was less than 0");//gets skipped if num isn’t > 0
		
		MyLabel: // goes here when num is greater than 0
		print("I jumped to MyLabel");	
	}

	// Update is called once per frame
	void Update()
	{
	
	}
}
