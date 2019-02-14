using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PrintAll();
	}

	public void ButtonClick()
	{
		print("Button click");
	}

	void PrintAll()
	{
		print("R_triggerDown : " + VIVEControllers.instance.R_triggerDown);
		print("R_triggerUp : " + VIVEControllers.instance.R_triggerUp);
		print("L_triggerDown : " + VIVEControllers.instance.L_triggerDown);
		print("L_triggerUp : " + VIVEControllers.instance.L_triggerUp);
		print("R_triggerValue : " + VIVEControllers.instance.R_triggerValue);
		print("L_triggerValue : " + VIVEControllers.instance.L_triggerValue);

		print("R_trackpadDown : " + VIVEControllers.instance.R_trackpadDown);
		print("R_trackpadUp : " + VIVEControllers.instance.R_trackpadUp);
		print("R_trackpadTouchAxis : " + VIVEControllers.instance.R_trackpadTouchAxis);
		print("R_trackpadScrollValue : " + VIVEControllers.instance.R_trackpadScrollValue);
		print("L_trackpadDown : " + VIVEControllers.instance.L_trackpadDown);
		print("L_trackpadUp : " + VIVEControllers.instance.L_trackpadUp);
		print("L_trackpadTouchAxis : " + VIVEControllers.instance.L_trackpadTouchAxis);
		print("L_trackpadScrollValue : " + VIVEControllers.instance.L_trackpadScrollValue);

		print("R_gripGrabDown : " + VIVEControllers.instance.R_gripGrabDown);
		print("R_gripGrabUp : " + VIVEControllers.instance.R_gripGrabUp);
		print("L_gripGrabDown : " + VIVEControllers.instance.L_gripGrabDown);
		print("L_gripGrabUp : " + VIVEControllers.instance.L_gripGrabUp);

		print("L_hitPosition : " + VIVEControllers.instance.L_hitPosition);
		print("R_hitPosition : " + VIVEControllers.instance.R_hitPosition);
		print("L_hitObject : " + VIVEControllers.instance.L_hitObject);
		print("R_hitObject : " + VIVEControllers.instance.R_hitObject);
	}
}
