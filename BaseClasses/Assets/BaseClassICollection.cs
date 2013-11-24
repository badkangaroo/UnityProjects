using UnityEngine;
using System.Collections;

public abstract partial class BaseClass : IEnumerator, ICollection
{
	public void CopyTo(System.Array array, int index)
	{
		throw new System.NotImplementedException();
	}

	public int Count
	{
		get
		{
			throw new System.NotImplementedException();
		}
	}

	public object SyncRoot
	{
		get
		{
			throw new System.NotImplementedException();
		}
	}

	public bool IsSynchronized
	{
		get
		{
			throw new System.NotImplementedException();
		}
	}
}