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

	/*************************************
	     ∧___∧                     ∧_＿∧
	  （　・∀・）    Grip    	  （´∀｀　）
	 （　　　　つ				  ⊂　　　　）
	**************************************/


	

	
}
