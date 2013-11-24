using UnityEngine;
using System.Collections;

public class Strings : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		//string s = "Something in quotes";
		//string s = "First word" + " Second word";
		string s = "First line\nSecond Line";
		s += "more words";
		print(s);
		bool b = s.Contains("Something");
		print(b);
	}
	
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
					CustomBox cBox = new CustomBox();
					cBox.box.transform.position =
						new Vector3(Counter * HorizontalSpacing,
						            i * VerticalSpacing,
						            j * HorizontalSpacing);
					cBox.PickRandomColor();
				}
			}
			Counter--;
		}
	}
}
class CustomBox
{
	public GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
	public void PickRandomColor()
	{
		//you'll want to try your hand at this yourself!
	}
}
