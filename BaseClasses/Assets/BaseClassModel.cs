using UnityEngine;
using System.Collections;

public abstract partial class BaseClass
{
	public enum Shapes
	{
		Box,
		Sphere
	}
	private Shapes mShape;
	protected Shapes MyShape
	{
		get{ return mShape;}
		set{ mShape = value;}
	}
	public abstract void SetShape(Shapes shape);
}

public partial class ChildA : BaseClass
{
	public override void SetShape(Shapes shape)
	{
		switch (shape)
		{
			case Shapes.Box:
				this.me = GameObject.CreatePrimitive(PrimitiveType.Cube);
				break;
			case Shapes.Sphere:
				this.me = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				break;
		}
	}
}