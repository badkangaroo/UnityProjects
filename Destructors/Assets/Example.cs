using UnityEngine;
using System.Collections;
using System;
public class Example : MonoBehaviour
{
	DestroyMe dm;
	private int counter = 10;
	delegate void updateHandler();
	event updateHandler updateEvent;
	
	ArrayList DestroyList = new ArrayList();
	
	// Use this for initialization
	void Start()
	{
		dm = new DestroyMe("rob");
		updateEvent += dm.OnUpdate;
		//dm = null;
		DestroyList.Add(new DestroyMe("white"));
		DestroyList.Add(new DestroyMe("stubbs"));
		DestroyList.Add(new DestroyMe("berney"));
	}
	
	// Update is called once per frame
	void Update()
	{
		if (updateEvent != null)
		{
			updateEvent();
			counter --;
			if (counter <= 0)
			{
				//updateEvent -= dm.OnUpdate;
				dm = null;
				updateEvent = null;
				GC.Collect();
			}
		}
		
		for (int i = 0; i < DestroyList.Count; i++)
		{
			DestroyMe d = DestroyList [i] as DestroyMe;
			if (counter <= 0)
			{
				if (d.name == "berney")
				{
					DestroyList.Remove(DestroyList [i]);
					GC.Collect();
				}
			}
			d.OnUpdate();
		}

	}
}



//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using System;
//using System.Linq;
//using Vect3 = UnityEngine.Vector3;
//
//public class Example : MonoBehaviour
//{
//	DestroyMe dm;
//	private int counter = 10;
//	delegate void updateHandler();
//	event updateHandler updateEvent;
//	
//	ArrayList DestroyList = new ArrayList();
//	
//	// Use this for initialization
//	void Start()
//	{
//		List<int> numbers = new List<int>{1,3,5,7,9,10};
//		var query = from n in numbers where n % 2 == 0 select n;
//
//		dm = new DestroyMe("rob");
//		updateEvent += dm.OnUpdate;
//		//dm = null;
//		DestroyList.Add(new DestroyMe("white"));
//		DestroyList.Add(new DestroyMe("stubbs"));
//		DestroyList.Add(new DestroyMe("berney"));
//		Vect3 v = new Vect3();
//		
//		
//	}
//	
//	// Update is called once per frame
//	void Update()
//	{
//		if (updateEvent != null)
//		{
//			updateEvent();
//			counter --;
//			if (counter <= 0)
//			{
//				//updateEvent -= dm.OnUpdate;
//				dm = null;
//				updateEvent = null;
//				GC.Collect();
//			}
//		}
//		
//		for (int i = 0; i < DestroyList.Count; i++)
//		{
//			DestroyMe d = DestroyList [i] as DestroyMe;
//			if (counter <= 0)
//			{
//				if (d.name == "berney")
//				{
//					DestroyList.Remove(DestroyList [i]);
//					GC.Collect();
//				}
//			}
//			d.OnUpdate();
//		}
//	}
//}