﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	public Camera followCamera;
	public Camera overHeadCamera;
	public Camera secondCamera;
	public Camera tankFollowCam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Alpha1)){
			showOverHead ();
		}
		if(Input.GetKeyUp(KeyCode.Alpha2)){
			showFollow ();
		}
		if (Input.GetKeyUp (KeyCode.Alpha3)) {
			showSecondView ();
		}
		if (Input.GetKeyUp (KeyCode.Alpha4)) {
			showTankFollowCam ();
		}
	}

	public void showOverHead()
	{
		followCamera.enabled = false;
		overHeadCamera.enabled = true;
		secondCamera.enabled = false;
		tankFollowCam.enabled = false;
	}

	public void showFollow()
	{
		followCamera.enabled = true;
		overHeadCamera.enabled = false;
		tankFollowCam.enabled = false;
		secondCamera.enabled = false;
	}

	public void showSecondView()
	{
		followCamera.enabled = false;
		overHeadCamera.enabled = false;
		tankFollowCam.enabled = false;
		secondCamera.enabled = true;
	}

	public void showTankFollowCam()
	{
		followCamera.enabled = false;
		overHeadCamera.enabled = false;
		secondCamera.enabled = false;
		tankFollowCam.enabled = true;
	}
}
