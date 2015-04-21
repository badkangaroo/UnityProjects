using UnityEngine;
using System.Collections;

public class Grid2D : MonoBehaviour
{
	public int Width;
	public int Height;
	public GameObject PuzzlePiece;
	private GameObject[,] Grid;

	// Use this for initialization
	void Start()
	{
		Grid = new GameObject[Width, Height];
		for (int x = 0; x < Width; x++)
		{
			for (int y = 0; y < Height; y++)
			{
				GameObject go =
					GameObject.Instantiate(PuzzlePiece) as GameObject;
				Vector3 position = new Vector3(x, y, 0);
				go.transform.position = position;
				Grid [x, y] = go;
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 mPosition =
			Camera.main.ScreenToWorldPoint(Input.mousePosition);
		UpdatePickedPiece(mPosition);
	}
	
	void UpdatePickedPiece(Vector3 position)
	{
		
		int x = (int)(position.x + 0.5f);
		int y = (int)(position.y + 0.5f);
		
		for (int _x = 0; _x < Width; _x++)
		{
			for (int _y = 0; _y < Height; _y++)
			{
				GameObject go = Grid [_x, _y];
				go.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
			}
		}
		
		if (x >= 0 && y >= 0 && x < Width && y < Height)
		{
			GameObject go = Grid [x, y];
			go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
		}
	}
}
