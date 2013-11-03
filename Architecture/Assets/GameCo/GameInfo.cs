using UnityEngine;
using System.Collections;

namespace AGameCo
{
	public class GameInfo
	{
		private int timesPlayed;
		public int TimesPlayed {get{return timesPlayed;} set{timesPlayed = value;}}
		public GameStats GetGameInfo()
		{
			GameStats gameStats = new GameStats();
			gameStats.timesPlayed = timesPlayed;
			return gameStats;
		}
	}
}
