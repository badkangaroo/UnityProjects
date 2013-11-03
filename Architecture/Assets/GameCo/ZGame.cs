using UnityEngine;
using System.Collections;

using AGameCo;
using AGameCo.ZGame;
using AGameCo.ZGame.Zombie;
using AGameCo.ZGame.Damage;

public class ZGame : Behavior {

	// Use this for initialization
	void Start () {
		Zombie stubbs = new Zombie();
		stubbs.InitZombie();
	}
}
