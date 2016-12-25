using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	[SerializeField]
	public Text highScoreText;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		highScoreText.text = "high score : " + GameOver.highScore;;

	}
}
