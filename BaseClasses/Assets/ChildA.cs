using UnityEngine;
using System.Collections;

public partial class ChildA : BaseClass
{
	#region ChildA_properties
	protected GameObject me;
	#endregion
	public override void Initialize(Mesh mesh, Material material)
	{
		this.MyMesh = mesh;
		this.MyMaterial = material;
		me = new GameObject(this.ToString());
		MyMeshFilter = me.AddComponent<MeshFilter>();
		MyMeshFilter.mesh = this.MyMesh;
		MyMeshRenderer = me.AddComponent<MeshRenderer>();
		MyMeshRenderer.material = this.MyMaterial;
	}
	
	public override void MoveForward(float speed, float turn)
	{
		Speed = speed;
		Turn += turn;
		ChildRotation = new Vector3(0, Turn, 0);
	}

	public override void ChildUpdate()
	{
		ChildTransform = me.transform.forward * Speed;
		me.transform.localPosition += ChildTransform;
		me.transform.localEulerAngles = ChildRotation;
	}
	
	public override void Speak()
	{
		Debug.Log(me.name + " word");
	}
}