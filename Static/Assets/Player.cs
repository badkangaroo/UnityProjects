using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	Vector3 pos;
	// Use this for initialization
	void Start()
	{
	
	}
	
	// Update is called once per frame
	void Update()
	{
		bool WKey = Input.GetKey(KeyCode.W);
		bool SKey = Input.GetKey(KeyCode.S);
		bool AKey = Input.GetKey(KeyCode.A);
		bool DKey = Input.GetKey(KeyCode.D);
		if (WKey)
		{
			pos.z += 0.1f;
		}
		if (SKey)
		{
			pos.z -= 0.1f;
		}
		if (AKey)
		{
			pos.x -= 0.1f;
		}
		if (DKey)
		{
			pos.x += 0.1f;
		}
		gameObject.transform.position = pos;
		//add in a check for the A key
		//bool AKey = Input.GetKey(KeyCode.A);
		//if (AKey)
		//{
		//	Debug.Log("AKey");
		//	//calls the static function in Zombie
		//	Zombie.CountZombies();
		//}
		//Input MyInput = new Input();
		//bool AKey = MyInput.GetKey( KeyCode.A );
		//Debug.Log( AKey ); 
	}
}
