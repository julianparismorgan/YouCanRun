﻿using UnityEngine;
using System.Collections;

public class GameInitialization : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CreateScene ();
		InitializePlayer ();
		SpawnZombies ();

		GameObject Countdown = GameObject.Find ("Countdown");
		Countdown.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateScene(){
		return;
	}
	void SpawnZombies(){
		//maybe put a countdown timer for the enemies spawning?
		return;
	}
	void InitializePlayer (){
		return;
	}
		
}
