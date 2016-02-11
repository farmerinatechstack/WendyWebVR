using UnityEngine;
using System.Collections;

public class MouseCameraControl : MonoBehaviour {

	public MouseLook mouseLook;
	public Camera targetCamera;

	void Start () {
        print("Start from RegularCameraRig");
		mouseLook.Init(transform, targetCamera.transform);
	}

	void Update () {
		mouseLook.LookRotation(transform, targetCamera.transform);
	}
	
}
