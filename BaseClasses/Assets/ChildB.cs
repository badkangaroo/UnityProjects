using UnityEngine;
using System.Collections;

//sneaking code into a base class
public partial class ChildA : BaseClass
{
	private float mScale;
	protected float MyScale
	{
		get { return mScale;}
		set { mScale = value;}
	}
	protected void SetScale(float scale)
	{
		MyScale = scale;
		me.transform.localScale = Vector3.one * MyScale;
	}
}

public class ChildB : ChildA
{
#region ChildB_properties
	private Color mColor;
	public Color MyColor
	{
		get { return mColor;}
		set { mColor = value;}
	}
#endregion
#region ChildB_functions
	public override void Initialize(Mesh mesh, Material material)
	{
		base.Initialize(mesh, material);
		this.MyColor = new Color(1, 0, 0, 1);
		MyMeshRenderer.material.color = this.MyColor;
		//using the SetScale function just added to ChildA
		SetScale(2.0f);
	}
#endregion
}