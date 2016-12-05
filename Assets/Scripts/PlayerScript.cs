﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerScript : MonoBehaviour {
	public int health;
	public Vector3 player_position;

	private GameObject mainMenu;
	private MainMenuStart mainMenuScript;
	private CharacterController controller;
	private FirstPersonController fpc; 

	// Use this for initialization
	void Start () {
		//grab main menu script
		mainMenu = GameObject.Find ("MainMenu");
		mainMenuScript = mainMenu.GetComponent<MainMenuStart> ();

		//grab character controller
		controller = this.GetComponent<CharacterController>();
		fpc = GameObject.FindObjectOfType<FirstPersonController>();
	}
	
	// Update is called once per frame
	void Update () {
		//set player position
		player_position = transform.position;

		//update player stats
		updatePlayerStats ();
	}


	void updatePlayerStats (){
		//set player height
		controller.height = mainMenuScript.playerHeight;

		//set player speed
		fpc.m_WalkSpeed = mainMenuScript.playerSpeed;
		fpc.m_RunSpeed = mainMenuScript.playerSpeed + 10;
	}


	void OnCollisionEnter(Collision collision) {
		print (collision);
		if (collision.gameObject.name == "Enemy") {
			mainMenuScript.isDead = true;
		}
	}
}
