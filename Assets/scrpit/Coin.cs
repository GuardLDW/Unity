using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin : MonoBehaviour {

	[SerializeField]
	private Transform player;

	private GameObject[] coinList;


	public GameObject coinPrefab;

	private bool isLock;

	// Use this for initialization
	void Start () {

		isLock = false;

		player.transform.position = transform.TransformDirection(player.transform.position);

		coinList = new GameObject[100];

		//刚进入场景时先生成一次金币
		createCoin ();
	

	}	

	// Update is called once per frame
	void Update () {

		if (ChangedLight.totalTime % 2 == 0 && !isLock) {

			//每天金币刷新一次后进入锁定状态，不能再被刷新

			for (int i = 0; i < coinList.Length; i++) {

				Destroy(GameObject.Find("coin_" + i));

			}
			createCoin ();

			isLock = true;

		}else if(ChangedLight.totalTime % 2 != 0){

			isLock = false;
		}




	}



	private void createCoin(){

		for (int i = 0; i < coinList.Length; i++) {

			GameObject oneCoin = Instantiate(coinPrefab);
			oneCoin.transform.position = new Vector3(Random.Range(-200,200), 1.3f, Random.Range(-40, 400));
			oneCoin.transform.rotation = Quaternion.AngleAxis(90, new Vector3(1, 0, 0));
			oneCoin.name = "coin_" + i;
			coinList[i] = oneCoin;
		}

	}
}
