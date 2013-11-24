using UnityEngine;
using System.Collections;

public abstract partial class BaseClass : IEnumerator, ICollection
{

	public IEnumerator GetEnumerator()
	{
		throw new System.NotImplementedException();
	}

	public bool MoveNext()
	{
		throw new System.NotImplementedException();
	}

	public void Reset()
	{
		throw new System.NotImplementedException();
	}

	public object Current
	{
		get
		{
			throw new System.NotImplementedException();
		}
	}
}