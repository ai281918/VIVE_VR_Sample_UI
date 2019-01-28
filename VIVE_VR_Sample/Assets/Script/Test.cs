using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print(VIVEControllers.instance.L_trackpadScrollValue);
		if(VIVEControllers.instance.L_trackpadDown){
			print("L_trackpadDown");
		}
		print(VIVEControllers.instance.R_triggerValue);
		print(VIVEControllers.instance.L_triggerValue);
	}
}
