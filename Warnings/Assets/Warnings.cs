using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class Warnings : MonoBehaviour
{
	
	void Start()
	{
		FileStream file = null;
		FileInfo fileInfo = null;

		try
		{
			fileInfo = new FileInfo("C:\\file.txt");
			
			file = fileInfo.OpenWrite();
			
			for (int i = 0; i < 255; i++)
			{
				file.WriteByte((byte)i);
			}
		} catch (UnauthorizedAccessException e)
		{
			Debug.LogWarning(e.Message);
		} finally
		{
			if (file != null)
			{
				file.Close();
			}
		}
	}
	
	public string input;
	public int i;
	public class MyException : Exception
	{
		public int Number;
		
		public MyException()
		{
		}
		
		public MyException(string message) : base(message)
		{
		}
		
		public MyException(string message, Exception innerException)
			: base(message,innerException)
		{
		}
	}
	
	int CheckInput(string s)
	{
		int parsed = 0;
		
		if (string.IsNullOrEmpty(s))
		{
			MyException e = new MyException("null");
			
			e.Number = 0;
			throw e;
		}

		parsed = int.Parse(s);
		
		if (parsed > 100)
		{
			MyException e = new MyException("too high");
			e.Number = parsed;
			throw e;
		}
		if (parsed < 0)
		{
			throw new UnassignedReferenceException();
		}
		return parsed;
	}

	void Update()
	{
		i = 0;
		
		//give parsing a string a shot
		try
		{
			i = CheckInput(input);
		} catch (MyException e)
		{
			i = e.Number;
			if (e.Message == "too high")
			{
				Debug.Log("use a lower number");
			} else if (e.Message == "null")
			{
				Debug.Log("input a number");
			}
		} finally
		{
			Debug.Log("done!");
		}
		
		Debug.Log("i = " + i);
	}
}