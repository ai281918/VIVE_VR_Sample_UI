using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VIVEControllers : MonoBehaviour{
	static VIVEControllers _instance;
	public static VIVEControllers instance{
		get{
			if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(VIVEControllers)) as VIVEControllers;
                if (_instance == null)
                {
                    GameObject go = new GameObject("VIVEControllers");
                    _instance = go.AddComponent<VIVEControllers>();
                }
            }
            return _instance;
		}
	}

	void Update()
	{
		R_DetectTrackpadScroll();
		L_DetectTrackpadScroll();
	}

	/*************************************
	     ∧___∧                     ∧_＿∧
	  （　・∀・）    Trigger	  （´∀｀　）
	 （　　　　つ				  ⊂　　　　）
	**************************************/

	public bool R_triggerDown{
		get{
			return SteamVR_Input._default.inActions.InteractUI.GetStateDown(SteamVR_Input_Sources.RightHand);
		}
	}

	public bool L_triggerDown{
		get{
			return SteamVR_Input._default.inActions.InteractUI.GetStateDown(SteamVR_Input_Sources.LeftHand);
		}
	}

	public bool R_triggerUp{
		get{
			return SteamVR_Input._default.inActions.InteractUI.GetStateUp(SteamVR_Input_Sources.RightHand);
		}
	}

	public bool L_triggerUp{
		get{
			return SteamVR_Input._default.inActions.InteractUI.GetStateUp(SteamVR_Input_Sources.LeftHand);
		}
	}

	public float R_triggerValue{
		get{
			return SteamVR_Input._default.inActions.Squeeze.GetAxis(SteamVR_Input_Sources.RightHand) > 0.05 ? SteamVR_Input._default.inActions.Squeeze.GetAxis(SteamVR_Input_Sources.RightHand) : 0;
		}
	}

	public float L_triggerValue{
		get{
			return SteamVR_Input._default.inActions.Squeeze.GetAxis(SteamVR_Input_Sources.LeftHand) > 0.05 ? SteamVR_Input._default.inActions.Squeeze.GetAxis(SteamVR_Input_Sources.LeftHand) : 0;
		}
	}

	/*************************************
	     ∧___∧                     ∧_＿∧
	  （　・∀・）    Trackpad	  （´∀｀　）
	 （　　　　つ				  ⊂　　　　）
	**************************************/
	float _R_trackpadScrollValue = 0f;
	Vector2 R_prevTrackpadTouchAxis = new Vector2();
	bool R_trackpadFirstScroll = true;

	public bool R_trackpadDown{
		get{
			return SteamVR_Input._default.inActions.Teleport.GetStateDown(SteamVR_Input_Sources.RightHand);
		}
	}

	public bool R_trackpadUp{
		get{
			return SteamVR_Input._default.inActions.Teleport.GetStateUp(SteamVR_Input_Sources.RightHand);
		}
	}

	public Vector2 R_trackpadTouchAxis{
		get{
			return SteamVR_Input._default.inActions.TrackpadTouchAxis.GetAxis(SteamVR_Input_Sources.RightHand);
		}
	}

	public float R_trackpadScrollValue{
		get{
			return Mathf.Max(Mathf.Abs(_R_trackpadScrollValue)-0.03f, 0f) * (_R_trackpadScrollValue > 0 ? 1 : -1);
		}
	}

	void R_DetectTrackpadScroll()
	{
		if(Mathf.Abs(R_trackpadTouchAxis.x) < 0.1f && Mathf.Abs(R_trackpadTouchAxis.y) < 0.1f){
			_R_trackpadScrollValue = 0f;
			R_trackpadFirstScroll = true;
			return;
		}

		if(R_trackpadFirstScroll){
			R_trackpadFirstScroll = false;
		}
		else{
			_R_trackpadScrollValue = Vector3.Cross(R_prevTrackpadTouchAxis, R_trackpadTouchAxis).z * -1;
		}
		R_prevTrackpadTouchAxis = R_trackpadTouchAxis;
	}

	float _L_trackpadScrollValue = 0f;
	Vector2 L_prevTrackpadTouchAxis = new Vector2();
	bool L_trackpadFirstScroll = true;

	public bool L_trackpadDown{
		get{
			return SteamVR_Input._default.inActions.Teleport.GetStateDown(SteamVR_Input_Sources.LeftHand);
		}
	}

	public bool L_trackpadUp{
		get{
			return SteamVR_Input._default.inActions.Teleport.GetStateUp(SteamVR_Input_Sources.LeftHand);
		}
	}

	public Vector2 L_trackpadTouchAxis{
		get{
			return SteamVR_Input._default.inActions.TrackpadTouchAxis.GetAxis(SteamVR_Input_Sources.LeftHand);
		}
	}

	public float L_trackpadScrollValue{
		get{
			return Mathf.Max(Mathf.Abs(_L_trackpadScrollValue)-0.03f, 0f) * (_L_trackpadScrollValue > 0 ? 1 : -1);
		}
	}

	void L_DetectTrackpadScroll()
	{
		if(Mathf.Abs(L_trackpadTouchAxis.x) < 0.1f && Mathf.Abs(L_trackpadTouchAxis.y) < 0.1f){
			_L_trackpadScrollValue = 0f;
			L_trackpadFirstScroll = true;
			return;
		}

		if(L_trackpadFirstScroll){
			L_trackpadFirstScroll = false;
		}
		else{
			_L_trackpadScrollValue = Vector3.Cross(L_prevTrackpadTouchAxis, L_trackpadTouchAxis).z * -1;
		}
		L_prevTrackpadTouchAxis = L_trackpadTouchAxis;
	}

	/*************************************
	     ∧___∧                     ∧_＿∧
	  （　・∀・）    Grip    	  （´∀｀　）
	 （　　　　つ				  ⊂　　　　）
	**************************************/
	public bool R_gripGrabDown{
		get{
			return SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.RightHand);
		}
	}

	public bool R_gripGrabUp{
		get{
			return SteamVR_Input._default.inActions.GrabGrip.GetStateUp(SteamVR_Input_Sources.RightHand);
		}
	}

	public bool L_gripGrabDown{
		get{
			return SteamVR_Input._default.inActions.GrabGrip.GetStateDown(SteamVR_Input_Sources.LeftHand);
		}
	}

	public bool L_gripGrabUp{
		get{
			return SteamVR_Input._default.inActions.GrabGrip.GetStateUp(SteamVR_Input_Sources.LeftHand);
		}
	}
}
