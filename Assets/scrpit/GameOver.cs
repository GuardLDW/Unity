using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	[SerializeField]
	public Text scoreText;

	[SerializeField]
	public Text newRecordText;
	
	public static int highScore;
	

	// Use this for initialization
	void Start () {

		scoreText.text = "Score : " + Player.totalScore;
		if (Player.totalScore > highScore) {
			
			highScore = Player.totalScore;
			newRecordText.text = "You get a new record !";

		} else {

			newRecordText.text = "";
		}
	
	}
}
