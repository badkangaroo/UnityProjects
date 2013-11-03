using UnityEngine;
using System.Collections;

public sealed class GameTimer : Object {
	
	public GameTimer()
	{
		GameTimer.NumTimers++;
	}
	
	void OnDestroy()
	{
		End();
		GameTimer.NumTimers--;
	}
	
	private float _time;
	public float mTime
	{
		get
		{
			return _time;
		}
		set
		{
			if( value > 0 )
			{
				if( Tick != null )
				{
					Tick( _time );
				}
				_time = value;
			}
			else
			{
				_time = 0;
			}
		}
	}

	public float timeLeft
	{
		get
		{
			return _time;
		}
	}
	
	public static int NumTimers;
	
	public delegate void tick(float t);
	public event tick Tick;
	public delegate void end();
	public event end End;
	
	public IEnumerator Update(float deltatime)
	{
		if( timeLeft > 0 )
		{
			mTime -= deltatime;
			yield return new WaitForSeconds( deltatime );
			Update( deltatime );
		}
		else
		{
			if( End != null ) {
				End();
			}
			Destroy(this);
		}
	}
}
