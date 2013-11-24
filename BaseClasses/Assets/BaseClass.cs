using UnityEngine;
using System.Collections;

public abstract partial class BaseClass : IEnumerator, ICollection
{
	#region BaseProperties
	private float speed;
	protected float Speed
	{
		get { return speed;}
		set { speed = value;}
	}
	private float turn;
	protected float Turn
	{
		get { return turn;}
		set { turn = value;}
	}
	private Vector3 transform;
	protected Vector3 ChildTransform
	{
		get { return transform;}
		set { transform = value;}
	}
	private Vector3 rotation;
	protected Vector3 ChildRotation
	{
		get { return rotation;}
		set { rotation = value;}
	}
	private MeshFilter mMeshFilter;
	protected MeshFilter MyMeshFilter
	{
		get{ return mMeshFilter; }
		set{ mMeshFilter = value;}
	}
	private MeshRenderer mRenderer;
	protected MeshRenderer MyMeshRenderer
	{
		get{ return mRenderer; }
		set{ mRenderer = value;}
	}
	private Material mMaterial;
	protected Material MyMaterial
	{
		get{ return mMaterial; }
		set{ mMaterial = value;}
	}
	private Mesh mMesh;
	protected Mesh MyMesh
	{
		get{ return mMesh; }
		set{ mMesh = value;}
	}
	#endregion
	#region BaseMethods
	public abstract void Initialize(Mesh mesh, Material material);
	public abstract void MoveForward(float spd, float trn);
	public abstract void ChildUpdate();
	public virtual void Speak()
	{
		Debug.Log("base hello");
	}
	#endregion
}
