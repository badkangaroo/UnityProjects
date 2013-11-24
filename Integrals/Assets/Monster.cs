using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
	public enum MonsterState
	{
		standing,
		wandering,
		chasing,
		attacking
	}
	public MonsterState mState;

	// Use this for initialization
	public GameObject PlayerObject;
	void Start()
	{
		int number = (int)mState;
		Debug.Log(number);
		Vector3 pos = new Vector3();
		pos.x = Random.Range(-10f, 10f);
		pos.z = Random.Range(-10f, 10f);
		transform.position = pos;
		GameObject[] AllGameObjects = 
			GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject aGameObject in AllGameObjects)
		{
			Component aComponent = aGameObject.GetComponent(typeof(Player));
			if (aComponent != null)
			{
				PlayerObject = aGameObject;
			}
		}
	}
	
	// Update is called once per frame
	Vector3 Direction; //class scoped variable
	public float AttackRange = 3.0f;
	public float SpeedMultiplyer = 0.01f;
	void Update()
	{
		if (mState == MonsterState.standing)
		{
			print("standing monster is standing."); 
		}
		if (mState == MonsterState.wandering)
		{
			print("wandering monster is wandering."); 
		}
		if (mState == MonsterState.chasing)
		{
			print("chasing monster is chasing."); 
		}
		if (mState == MonsterState.attacking)
		{
			print("attacking monster is attacking."); 
		}
//		Gizmos.DrawLine(transform.position, new Vector3(0, 0, 0));
		Vector3 MyVector = PlayerObject.transform.position - transform.position;
//		float DistanceToPlayer = MyVector.magnitude;
//		float DistanceToPlayer = (PlayerObject.transform.position - transform.position).magnitude;
		
		if ((PlayerObject.transform.position - transform.position).magnitude > AttackRange)
		{
//			Direction =
//				Vector3.Normalize(PlayerObject.transform.position - 
//				transform.position);
			transform.position += Vector3.Normalize(PlayerObject.transform.position - 
				transform.position) * SpeedMultiplyer;
		}
	}

	void OnDrawGizmos()
	{
//		Gizmos.DrawLine(transform.position, new Vector3(0, 0, 0));
//		Gizmos.DrawLine(transform.position, PlayerObject.transform.position);
		Gizmos.DrawLine(transform.position, transform.position + Direction);
	}

}
