using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
	public GameObject eventSystem, VREventSystem;

	void Start()
	{
		eventSystem.SetActive(false);
		VREventSystem.SetActive(true);
	}

	void FixedUpdate () {
		if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)){
			eventSystem.SetActive(true);
			VREventSystem.SetActive(false);
		}
		if(VIVEControllers.instance.R_triggerDown || VIVEControllers.instance.R_gripGrabDown || VIVEControllers.instance.R_trackpadDown
		|| VIVEControllers.instance.L_triggerDown || VIVEControllers.instance.L_gripGrabDown || VIVEControllers.instance.L_trackpadDown){
			eventSystem.SetActive(false);
			VREventSystem.SetActive(true);
		}
	}
}
