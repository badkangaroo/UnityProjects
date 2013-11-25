//using UnityEngine;
//using System.Collections;
//
//public class Enums : MonoBehaviour
//{
//	int[] ints = {3, 7, 11, 13, 17, 23 } ;
//	// Use this for initialization
//	void Start()
//	{
//		IEnumerator o = ints.GetEnumerator();
//		while (o.MoveNext())
//		{
//			Debug.Log(o.Current);
//		}
//	}
//}
using UnityEngine;
using System.Collections;

public class Enums : MonoBehaviour
{
	
	//zombie master
	class ZombieMaster : IEnumerable
	{
		public static string ZombieMasterName;
		private IZombieEnumerator Enumerator;
		public ZombieMaster(string name)
		{
			ZombieMasterName = name;
			Enumerator = new IZombieEnumerator();
		}
		public IEnumerator GetEnumerator()
		{
			return Enumerator;
		}
	}
	class IZombieEnumerator : IEnumerator
	{
		private string[] minions;
		private int NextMinion;
		public object Current
		{
			get { return minions [NextMinion];}
		}
		
		public IZombieEnumerator()
		{
			minions = new string[]{ "stubbs", "bernie", "michael" };
		}
		
		public bool MoveNext()
		{
			NextMinion++;
			if (NextMinion >= minions.Length)
			{
				return false;
			} else
			{
				return true;
			}
		}
		
		public void Reset()
		{
			NextMinion = -1;
		}
	}
	// Use this for initialization
	void Start()
	{
		ZombieMaster zombieMaster = new ZombieMaster("bob");
		
		Debug.Log(ZombieMaster.ZombieMasterName);
		
		foreach (object obj in zombieMaster)
		{
			Debug.Log(obj.ToString());
		}
	}
}
