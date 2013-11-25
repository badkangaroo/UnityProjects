
using UnityEngine;
using System.Collections;

public class LambdaExpressions : MonoBehaviour
{
	//create a delegate signature like before
	delegate int MyDelegate(int i);
	
	// Use this for initialization
	//delegate int MyDelegate(int i);
	void Start()
	{
		MyDelegate myLambda = (x) => x * x; 
		int y = myLambda(5);
		Debug.Log(y);
		
		MyDelegate myDelegate = delegate(int i)
		{
			return i * i;
		};
		int z = myDelegate(5);
		Debug.Log(z);
	}
}
//using UnityEngine;
//using System.Collections;
//
//public class LambdaExpressions : MonoBehaviour
//{
//	delegate void MyDelegate();
//	
//	// Use this for initialization
//	void Start()
//	{
//		MyDelegate myDelegatedTask = 
//			delegate()
//		{
//			Debug.Log("Hello from anon.");
//		}; 
//		
//		myDelegatedTask();
//	}
//}
//using UnityEngine;
//using System.Collections;
//
//public class LambdaExpressions : MonoBehaviour
//{
//	delegate void MyDelegate();
//	// Use this for initialization
//	void Start()
//	{
//		MyDelegate myDelegatedTask = delegate()
//		{
//			Debug.Log("Hello from anon.");
//		}; 
//		myDelegatedTask();
//	}
//}
