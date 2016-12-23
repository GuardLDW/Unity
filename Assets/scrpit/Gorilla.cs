using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gorilla : MonoBehaviour {

	[SerializeField]
	public Transform player;
	
	float Distance = 0f;

	// Use this for initialization
	void Awake () {	
		player.transform.position = transform.TransformDirection(player.transform.position);
		this.gameObject.transform.position = transform.TransformDirection(this.gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.Translate (new Vector3 (player.transform.position.x, 0 , player.transform.position.z), Space.World);

			
	}

	private void attackPlayer(){

		Player.totalScore = 0;

	}





}