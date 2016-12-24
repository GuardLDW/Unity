using UnityEngine;
using System.Collections;

public class startgameButton : MonoBehaviour {

	public void Click(){

		Application.LoadLevel("Game");
		Player.totalScore = 0;

	}
}
