using UnityEngine;
using System.Collections;
using System.Reflection;

using UnityEngine;
using System.Collections;
using System.Reflection;

public class ReflectionA : MonoBehaviour
{
	
	class subClassA
	{
		public static int firstInt;
		public string secondInt;
		public int thirdInt;
		public subClassA(int first, int second, int third)
		{
			firstInt = first;
			this.secondInt = second.ToString();
			this.thirdInt = third;
		}
		public void OnUpdate()
		{
			Debug.Log("subClassA Updating A");
		}
	}
	class subClassB
	{
		public void OnUpdate()
		{
			Debug.Log("subClassB Updating B");
		}
	}
	class subClassC
	{
		public void NotUpdate()
		{
		
		}
	}

	subClassA ca;
	subClassB cb;
	subClassC cc;	
	
	// Use this for initialization
	void Start()
	{
		ca = new subClassA(1, 2, 3);
		cb = new subClassB();
		cc = new subClassC();

		FieldInfo[] fields = typeof(subClassA).GetFields();
		foreach (FieldInfo field in fields)
		{
			Debug.Log(field.Attributes + " " + field.FieldType + " " + field.Name);
			
			if (field.FieldType == typeof(string))
			{
				field.SetValue(ca, "I found a string!");
			}
		}
		MemberInfo[] memberInfos = typeof(subClassA).GetMembers();
		foreach (MemberInfo m in memberInfos)
		{
			Debug.Log(m.ToString());
		}
		Debug.Log(ca.secondInt);
	}
	
	void Update()
	{
		ArrayList subClasses = new ArrayList();
		subClasses.Add(ca);
		subClasses.Add(cb);
		subClasses.Add(cc);
		foreach (object o in subClasses)
		{
			MethodInfo method = (MethodInfo)o.GetType().GetMethod("OnUpdate");
			if (method != null)
			{
				method.Invoke(o, null);
			}
		}		
	}
}

