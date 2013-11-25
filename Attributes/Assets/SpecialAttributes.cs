using System;
using UnityEngine;
using System.Collections;
using System.Reflection;

public class SpecialAttributes : MonoBehaviour
{

	[Serializable]
	public class nestedClass
	{
		public int myInt;
		
		[MyAttribute("Im so Special")]
		public int
			SpecialInt;
		
		[PlayerType(MyTypes.Monster)]
		[MyOtherAttribute(2)]
		public int
			OtherInt;
	}
	
	public nestedClass MyNestedClass;
	
	[NonSerialized]
	public int
		PlainOldInt;
	
	BaseClass[] baseClasses;
	
	void Start()
	{
		#region firstHalf
		MemberInfo[] memberInfos = typeof(nestedClass).GetMembers();
		foreach (MemberInfo info in memberInfos)
		{
			object[] myAttribs = info.GetCustomAttributes(true);
			foreach (Attribute attrib in myAttribs)
			{
				if (attrib is MyAttribute)
				{
					MyAttribute ma = attrib as MyAttribute;
					Debug.Log("found " 
						+ info.ToString()
						+ " attrib is a "
						+ ma.Name);
				}
				
				if (attrib is MyOtherAttribute)
				{
					MyOtherAttribute ma = attrib as MyOtherAttribute;
					Debug.Log("found " 
						+ info.ToString()
						+ " attrib is a "
						+ ma.OtherName);
				}

				if (attrib is PlayerType)
				{
					PlayerType pt = attrib as PlayerType;
					Debug.Log("found " + info.ToString() + " attrib is a " + pt.myType);
				}
			}
		}
		#endregion
		
		baseClasses = new BaseClass[10];
		for (int i = 0; i < 10; i ++)
		{
			BaseClass bc = new BaseClass(i.ToString());
			baseClasses [i] = bc;
		}
		GameObject.FindObjectsOfType(typeof(object));
		//assume we don't know what is in each object
		foreach (object o in baseClasses)
		{
			Type t = o.GetType();
			MethodInfo[] methods = t.GetMethods();
			foreach (MethodInfo method in methods)
			{
				object[] attributes = method.GetCustomAttributes(true);
				foreach (object attribute in attributes)
				{
					if (attribute is MyAttribute)
					{
						MyAttribute ma = attribute as MyAttribute;
						if (ma.Name == "Update")
						{
							EventInfo ei = typeof(SpecialAttributes).GetEvent("UpdateEvent");
							Type et = ei.EventHandlerType;
							Delegate d = Delegate.CreateDelegate(et, o, method);
							ei.AddEventHandler(this, d);
						}
					}
				}
			}
		}
	}
	public delegate void UpdateHandler();
	public event UpdateHandler UpdateEvent;
	void Update()
	{
		if (UpdateEvent != null)
			UpdateEvent();
	}
}