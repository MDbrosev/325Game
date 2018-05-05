using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStart : MonoBehaviour {
    //loc of camera and player
    private playerController player;
    private cameraControls camera;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<playerController>();
        //move pos of player to start point
        player.transform.position = transform.position;
        //same to camera
        camera = FindObjectOfType<cameraControls>();
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
