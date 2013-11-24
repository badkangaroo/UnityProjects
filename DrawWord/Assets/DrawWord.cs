using UnityEngine;
using System.Collections;

public class DrawWord : MonoBehaviour
{
	void Update()
	{
		Vector3 position = Vector3.zero;
		drawWord("words are being drawn", 2f, position, Color.black);
	}

	public static void drawWord(string word, float scale, Vector3 position, Color color)
	{
		//convert to uppercase first
		string uLetters = word.ToUpper();
		char[] letters = uLetters.ToCharArray();
		if (letters.Length > 0)
		{
			for (int i = 0; i < letters.Length; i++)
			{
				float offset = (i * scale);
				Vector3 offsetPosition = new Vector3(offset + position.x, position.y, position.z);
				drawWord(letters [i], scale, offsetPosition, color);
			}
		}
	}
	public static void drawWord(char c, float scale, Vector3 position, Color color)
	{
		Vector3[] lines = Letters.ToVectorArray(c);
		for (int i = 1; i < lines.Length; i++)
		{
			Vector3 start = (lines [i - 1] * scale);
			start.x *= 0.4f;
			Vector3 end = (lines [i] * scale);
			end.x *= 0.4f;
			Debug.DrawLine(start + position, end + position, color);
		}		
	}
}

public class Letters
{
	public static Vector3[] ToVectorArray(char c)
	{
		Vector3[] letter;
		switch (c)
		{
			case ' ':
				letter = space;
				break;
			case 'A':
				letter = A;
				break;
			case 'B':
				letter = B;
				break;
			case 'C':
				letter = C;
				break;
			case 'D':
				letter = D;
				break;
			case 'E':
				letter = E;
				break;
			case 'F':
				letter = F;
				break;
			case 'G':
				letter = G;
				break;
			case 'H':
				letter = H;
				break;
			case 'I':
				letter = I;
				break;
			case 'J':
				letter = J;
				break;
			case 'K':
				letter = K;
				break;
			case 'L':
				letter = L;
				break;
			case 'M':
				letter = M;
				break;
			case 'N':
				letter = N;
				break;
			case 'O':
				letter = O;
				break;
			case 'P':
				letter = P;
				break;
			case 'Q':
				letter = Q;
				break;
			case 'R':
				letter = R;
				break;
			case 'S':
				letter = S;
				break;
			case 'T':
				letter = T;
				break;
			case 'U':
				letter = U;
				break;
			case 'V':
				letter = V;
				break;
			case 'W':
				letter = W;
				break;
			case 'X':
				letter = X;
				break;
			case 'Y':
				letter = Y;
				break;
			case 'Z':
				letter = Z;
				break;
			default:
				letter = X;
				break;
		}
		return letter;
	}
	#region Letters
	public static Vector3[] space = new[] {
		new Vector3(0, 0, 0),
		new Vector3(0, 0, 0)
	};
	public static Vector3[] A = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 0, 0),
		new Vector3(0, 1, 0),
		new Vector3(1, 0, 0),
		new Vector3(-1, 0, 0),
		new Vector3(1, 0, 0),
		new Vector3(1, -1, 0)
	};
	
	public static Vector3[] B = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(0, 1, 0),
		new Vector3(1, 0, 0),
		new Vector3(-1, 0, 0),
		new Vector3(1, 0, 0),
		new Vector3(1, -1, 0),
		new Vector3(-1, -1, 0)
	};
	
	public static Vector3[] C = new[]{
		new Vector3(1, -1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] D = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(0, 1, 0),
		new Vector3(1, 0, 0),
		new Vector3(0, -1, 0),
		new Vector3(-1, -1, 0)
	};
	
	public static Vector3[] E = new[]{
		new Vector3(1, -1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(-1, 0, 0),
		new Vector3(0, 0, 0),
		new Vector3(-1, 0, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
	};
	
	public static Vector3[] F = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 0, 0),
		new Vector3(0, 0, 0),
		new Vector3(-1, 0, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] G = new[]{
		new Vector3(0, 0, 0),
		new Vector3(1, 0, 0),
		new Vector3(1, -1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
	};
	
	public static Vector3[] H = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(-1, 0, 0),
		new Vector3(1, 0, 0),
		new Vector3(1, 1, 0),
		new Vector3(1, -1, 0),
	};
	
	public static Vector3[] I = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(1, -1, 0),
		new Vector3(0, -1, 0),
		new Vector3(0, 1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
	};
	
	public static Vector3[] J = new[]{
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
		new Vector3(0, 1, 0),
		new Vector3(0, -1, 0),
		new Vector3(-1, 0, 0),
	};
	
	public static Vector3[] K = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(-1, 0, 0),
		new Vector3(1, 1, 0),
		new Vector3(-1, 0, 0),
		new Vector3(1, -1, 0)
	};
	
	public static Vector3[] L = new[]{
		new Vector3(-1, 1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(1, -1, 0)
	};
	
	public static Vector3[] M = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(0, 0, 0),
		new Vector3(1, 1, 0),
		new Vector3(1, -1, 0),
	};
	
	public static Vector3[] N = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, -1, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] O = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
		new Vector3(1, -1, 0),
		new Vector3(-1, -1, 0)
	};
	
	public static Vector3[] P = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
		new Vector3(1, 0, 0),
		new Vector3(-1, 0, 0)
	};
	
	public static Vector3[] Q = new[]{
		new Vector3(1, -1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
		new Vector3(1, -1, 0),
		new Vector3(0, 0, 0)
	};
	
	public static Vector3[] R = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
		new Vector3(1, 0, 0),
		new Vector3(-1, 0, 0),
		new Vector3(1, -1, 0)
	};
	
	public static Vector3[] S = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(1, -1, 0),
		new Vector3(1, 0, 0),
		new Vector3(-1, 0, 0),
		new Vector3(0, 1, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] T = new[]{
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
		new Vector3(0, 1, 0),
		new Vector3(0, -1, 0)
	};
	
	public static Vector3[] U = new[]{
		new Vector3(-1, 1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(1, -1, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] V = new[]{
		new Vector3(-1, 1, 0),
		new Vector3(0, -1, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] W = new[]{
		new Vector3(-1, 1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(0, 0, 0),
		new Vector3(1, -1, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] X = new[]{
		new Vector3(-1, -1, 0),
		new Vector3(0, 0, 0),
		new Vector3(-1, 1, 0),
		new Vector3(0, 0, 0),
		new Vector3(1, 1, 0),
		new Vector3(0, 0, 0),
		new Vector3(1, -1, 0)
	};
	
	public static Vector3[] Y = new[]{
		new Vector3(0, -1, 0),
		new Vector3(0, 0, 0),
		new Vector3(-1, 1, 0),
		new Vector3(0, 0, 0),
		new Vector3(1, 1, 0)
	};
	
	public static Vector3[] Z = new[]{
		new Vector3(-1, 1, 0),
		new Vector3(1, 1, 0),
		new Vector3(-1, -1, 0),
		new Vector3(1, -1, 0)
	};
	#endregion
}