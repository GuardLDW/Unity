using UnityEngine;
using System.Collections;
using System;


public class ChangedLight : MonoBehaviour {
	

	public Light light;

	private string lightColor;

	//记录当前昼夜总数
	public static int totalTime = 0;

	// Use this for initialization
	void Start () {

		lightColor = "yellow";
		light.color = Color.yellow;

		//白天与黑夜各持续24s
		System.Timers.Timer t = new System.Timers.Timer(24000);
		t.Elapsed += new System.Timers.ElapsedEventHandler(theout); //到达时间的时候执行事件
		t.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)；   
		t.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件； 

  
	}
	
	// Update is called once per frame
	void Update () {

		if (lightColor.Equals ("yellow")) {
			
			light.color = Color.yellow;
			
		} else if (lightColor.Equals ("black")) {
			
			light.color = Color.black;
			
		}

	}

	public void theout(object source, System.Timers.ElapsedEventArgs e)   
	{   
		changeLight();
	}

	//控件的颜色只能在主线程中修改，所以该子线程中改变颜色的标志状态
	public void changeLight(){

		if (lightColor.Equals ("yellow")) {

			lightColor = "black";

		} else if (lightColor.Equals ("black")) {

			lightColor = "yellow";

		}

		ChangedLight.totalTime++;


	}

}
