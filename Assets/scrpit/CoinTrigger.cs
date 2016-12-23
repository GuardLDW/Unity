using UnityEngine;
using System.Collections;


public class CoinTrigger : MonoBehaviour {
	

	//有物体碰撞的时候调用
	void OnTriggerEnter(Collider collider){

		if(collider.tag == "Player"){

			Player.totalScore = Player.totalScore + 10;
			Destroy(gameObject);
		}
	}
}
