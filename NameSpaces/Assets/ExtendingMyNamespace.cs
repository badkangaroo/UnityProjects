namespace MyNameSpace
{
	using UnityEngine;

	/* this causes a conflict
	public class MyClass
	{
		
	}*/
	
	public class AnotherClassInMyNamespace
	{
		public void MyFunction()
		{
			Debug.Log("hello from MyNamespace");
		}
	}
}