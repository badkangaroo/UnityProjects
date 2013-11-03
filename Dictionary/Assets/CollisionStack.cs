using UnityEngine;
using System.Collections;

public class CollisionStack : MonoBehaviour {
	public GameObject[] HitList;
	public GameObject[] QueueList;
	public Stack HitStack;
	public Queue HitQueue;
	#region Start
	void Start()
	{
		HitStack = new Stack();
		HitQueue = new Queue();
	}
	#endregion
	
	
	void OnTriggerEnter( Collider other )
	{
		#region TriggerStack
		if( !HitStack.Contains( other.gameObject ) )
		{
			HitStack.Push( other.gameObject );
			HitList = new GameObject[HitStack.Count];
			HitStack.CopyTo(HitList, 0);
		}
		#endregion
		#region TriggerQueue
		if( !HitQueue.Contains( other.gameObject ) )
		{
			HitQueue.Enqueue( other.gameObject );
			QueueList = new GameObject[HitQueue.Count];
			HitQueue.CopyTo(QueueList, 0);
		}
		#endregion
	}
	
	void Update () {
		#region UpdateStack
		if( HitStack.Count > 0 )
		{
			GameObject lastObject = HitStack.Peek() as GameObject;
			Debug.DrawLine( transform.position, lastObject.transform.position );
			if( HitList[0] == lastObject )
			{
				StartCoroutine("popTheStack");
			}
		}
		#endregion
		#region UpdateQueue
		if( HitQueue.Count > 0 )
		{
			GameObject firstObject = HitQueue.Peek() as GameObject;
			Debug.DrawLine( transform.position, firstObject.transform.position, Color.red );
			if( QueueList[0] == firstObject )
			{
				StartCoroutine("dequeueTheQueue");
			}
		}
		#endregion
	}
	#region popStack
	IEnumerator popTheStack()
	{
		yield return new WaitForSeconds(2);
		if( HitStack.Count > 0 )
		{
			HitStack.Pop();
			HitList = new GameObject[HitStack.Count];
			HitStack.CopyTo(HitList, 0);
			StopCoroutine("popTheStack");
		}
	}
	#endregion
	#region dequeueQueue
	IEnumerator dequeueTheQueue()
	{
		yield return new WaitForSeconds(2);
		if( HitQueue.Count > 0 )
		{
			HitQueue.Dequeue();
			QueueList = new GameObject[HitQueue.Count];
			HitQueue.CopyTo(QueueList, 0);
			StopCoroutine("dequeueTheQueue");
		}
	}
	#endregion
}
