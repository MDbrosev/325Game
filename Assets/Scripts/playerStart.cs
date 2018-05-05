using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStart : MonoBehaviour {
    //loc of camera and player
    private playerController player;
    private cameraControls startPtCamera;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<playerController>();
        //move pos of player to start point
        player.transform.position = transform.position;
        //same to camera
        startPtCamera = FindObjectOfType<cameraControls>();
        startPtCamera.transform.position = new Vector3(transform.position.x, transform.position.y, startPtCamera.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
