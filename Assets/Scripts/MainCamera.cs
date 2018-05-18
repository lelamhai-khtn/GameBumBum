using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
	public float height = 0;
	public float width = 0;

	// Use this for initialization
	void Start () {
		Camera cam = Camera.main;
        height = 2f * cam.orthographicSize;
        width = height * cam.aspect;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
