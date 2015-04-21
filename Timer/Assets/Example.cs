using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
	}
	// Update is called once per frame
	public float NextTime = 0f;
	public float Timer = 0.5f;
	public int Counter = 10;
	public int MinHeight = 1;
	public int MaxHeight = 10;
	public float HorizontalSpacing = 2f;
	public float VerticalSpacing = 1f;
	void Update()
	{
		if (Counter > 0 && Time.fixedTime > NextTime)
		{
			NextTime = Time.fixedTime + Timer;
			for (int j = 10; j > 0; j--)
			{
				int randomNumber = Random.Range(MinHeight, MaxHeight);
				for (int i = 0; i < randomNumber; i++)
				{
					CustomBox box = new CustomBox();
					box.box.transform.position = 
					new Vector3(Counter * HorizontalSpacing,
					            i * VerticalSpacing,
					            j * HorizontalSpacing);
					box.PickRandomColor();
				}
			}
			Counter--;
		}
	}
	class CustomBox
	{
		public GameObject box =
			GameObject.CreatePrimitive(PrimitiveType.Cube);
		public void PickRandomColor()
		{
			Color rc =
				new Color(Random.value, Random.value, Random.value, 1);
			box.GetComponent<Renderer>().material.color = rc;
		}
	}

}
