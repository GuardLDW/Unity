using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//旋转
		if (Input.GetKey(KeyCode.A)){

			//逆时针（向左转）
			this.transform.Rotate(Vector3.down, Space.World);

		}else if(Input.GetKey(KeyCode.D)){
			
			this.transform.Rotate(Vector3.up, Space.World);
			
		}

		//移动
		if (Input.GetKey(KeyCode.W)){
			
			//将第二个参数由世界坐标改成自身坐标即可完成向自身面朝方向移动
			this.transform.Translate(Vector3.forward / 25, Space.Self);
			
		}else if(Input.GetKey(KeyCode.S)){

			this.transform.Translate(Vector3.back / 25, Space.Self);
			
		}



	
	}
}
