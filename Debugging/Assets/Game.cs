using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
	public GameObject[] GameObjects;
	protected static string mText;
	public static string MyText
	{
		get{ return mText;}
		set{ mText = value;}
	}

	// Use this for initialization
	void Start()
	{
		GameObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		for (int i = 0; i < GameObjects.Length; i++)
		{
			MyText += GameObjects [i].name + "\n";
		}
	}

	void OnGUI()
	{
		GUI.BeginGroup(new Rect(0, 0, 300, 100));
		GUI.Box(new Rect(0, 0, 300, 100), MyText);
		GUI.EndGroup();
	}
}