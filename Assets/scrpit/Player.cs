using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour {

	[SerializeField]
	private Text scoreText;
	

	public static int totalScore = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//旋转
		if (Input.GetKey(KeyCode.Q)){

			//逆时针（向左转）
			this.transform.Rotate(Vector3.down * 2, Space.World);

		}else if(Input.GetKey(KeyCode.E)){
			
			this.transform.Rotate(Vector3.up * 2, Space.World);
			
		}

		//移动
		if (Input.GetKey(KeyCode.W)){
			
			//将第二个参数由世界坐标改成自身坐标即可完成向自身面朝方向移动
			this.transform.Translate(Vector3.forward / 3, Space.Self);
			
		}else if(Input.GetKey(KeyCode.S)){

			this.transform.Translate(Vector3.back / 3, Space.Self);
			
		}else if(Input.GetKey(KeyCode.A)){
			
			this.transform.Translate(Vector3.left / 3, Space.Self);
			
		}else if(Input.GetKey(KeyCode.D)){
			
			this.transform.Translate(Vector3.right / 3, Space.Self);
			
		}

		//一段跳

		if (Input.GetKeyDown(KeyCode.Space)) {

				this.transform.localPosition = Vector3.MoveTowards (this.transform.localPosition, new Vector3(this.transform.position.x, 6, this.transform.position.z), 1f);

		}else if (Input.GetKeyUp(KeyCode.Space)) {
			
			this.transform.localPosition = Vector3.MoveTowards (this.transform.localPosition, new Vector3(this.transform.position.x, 0 , this.transform.position.z), 1f);
			
		}


		scoreText.text = "SCORE:" + Player.totalScore;



	
	}
}
