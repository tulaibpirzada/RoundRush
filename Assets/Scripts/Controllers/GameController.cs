﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : Singleton<GameController> {

	GameReferences gameRef;
	GameObject gameContextObject;

	public bool IsUIOpened {
		get;
		set;
	}

	//Loads the game
	public void LoadGame(GameObject gameObject)
	{
		gameContextObject = gameObject;
		IsUIOpened = false;
		gameRef = gameContextObject.GetComponent<GameReferences> ();
		RoundRushGameController.Instance.ShowRoundRushGameScreen (gameRef.roundRushGameRef);
	}
}