//using UnityEngine;
//using System.Collections;
//public class Delegates : MonoBehaviour
//{
//	delegate void MyDelegate();
//	delegate int MyDelegate();
//	
//	void FirstDelegate()
//	{
//		Debug.Log("First delegate called");
//	}
//	
//	void SecondDelegate()
//	{
//		Debug.Log("Second delegate called");
//	}
//	delegate int MyDelegate(int a,int b);
//	
//	public int FirstDelegate(int a, int b)
//	{
//		return a + b;
//	}
//	
//	public int SecondDelegate(int a, int b)
//	{
//		return a - b;
//	}
//
//	// Use this for initialization
//	void Start()
//	{
//		MyDelegate del = new MyDelegate(FirstDelegate);
//		int add = del(7, 3);
//		Debug.Log(add);
//		
//		del = SecondDelegate;
//		int sub = del(103, 3);
//		Debug.Log(sub);
//	}

//	delegate void MyDelegate(int a);
//	public MyDelegate del;
//	
//	void FirstDelegate(int a)
//	{
//		Debug.Log("first delegate: " + a);
//	}
//	
//	void Start()
//	{
//		if (del == null)
//		{
//			del += FirstDelegate;
//			del(3);//prints "first delegate: 3"
//		}
//	}
//	delegate void MyDelegate(int a);
//	public MyDelegate del;
//	
//	void FirstDelegate(int a)
//	{
//		Debug.Log("first delegate: " + a);
//	}
//	
//	void SecondDelegate(int a)
//	{
//		Debug.Log("second delegate: " + a);
//	} 
//	
//	void Start()
//	{
//		if (del == null)
//		{
//			del += FirstDelegate;
//			del += SecondDelegate;
//			del(3);	//prints "first delegate: 3"
//			//and "second delegate: 3"
//		}
//	}
//
//	int GetThree()
//	{
//		return 3;
//	}
//	
//	void UseDelegate(MyDelegate d)
//	{
//		int gotNumber = d();
//		Debug.Log(gotNumber);
//	}
//	
//	// Update is called once per frame
//	void Update()
//	{
//	
//	}
//	
//	
//}
using UnityEngine;
using System.Collections;

public class Delegates : MonoBehaviour
{
	delegate int MyDelegate();
	delegate void Del();
	// Use this for initialization
	void Start()
	{
		int a = 10;
		
		Del d = delegate()
		{
			Debug.Log("delegate calling");
		};
		d();
		
		d = delegate()
		{
			Debug.Log("a/2 = " + a / 2);	
		};
		HandlesDel(d);
	}
	
	void HandlesDel(Del del)
	{
		del();
	}

	int GetThree()
	{
		return 3;
	}
	
	void UseDelegate(MyDelegate mDelegate)
	{
		int gotNumber = mDelegate();
		Debug.Log(gotNumber);
	}
}
