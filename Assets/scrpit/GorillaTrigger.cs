﻿using UnityEngine;
using System.Collections;

public class GorillaTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		
		if(collider.tag == "Player"){
			
			print ("die");
		}
	}
}