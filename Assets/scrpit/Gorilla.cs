using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gorilla : MonoBehaviour {

	[SerializeField]
	public Transform player;
	
	private float distanceToPlayer;//与玩家的距离
	private float distanceToFirst;//与最初位置的距离
	[SerializeField]
	private float patrolDistance;

	private float firstX;
	private float firstY;
	private float firstZ;

	// Use this for initialization
	void Awake () {	

		distanceToPlayer = 0;
		distanceToFirst = 0;
		firstX = this.transform.position.x;
		firstY = this.transform.position.y;
		firstZ = this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () 
	{

		distanceToPlayer = Vector3.Distance (this.gameObject.transform.position, player.transform.position);
		distanceToFirst = Vector3.Distance (this.gameObject.transform.position, new Vector3(firstX, firstY, firstZ));

		if (distanceToPlayer < patrolDistance && distanceToFirst < patrolDistance) {

			//移动到指定位置:人物位置
			this.transform.localPosition = Vector3.MoveTowards (this.transform.localPosition, player.transform.localPosition, 0.5f);

		} else if(distanceToPlayer >= patrolDistance || distanceToFirst >= patrolDistance){

			this.transform.localPosition = Vector3.MoveTowards (this.transform.localPosition, new Vector3(firstX, firstY, firstZ), 0.5f);

		}
		 

			
	}






}