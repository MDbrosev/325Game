using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControls : MonoBehaviour
{

    public GameObject target;
    private Vector3 targetposition;
    public float cameraSpeed;
    public static bool theCamera;

	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(transform.gameObject);

        if (!theCamera)
        {
            theCamera = true;
            //keep the object that this script is connected to
            //will put it at the same x and y position between worlds
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Target for camera, get the X and Y value of the target to follow and dont change the Z value since game is 2D
        //Param: X, Y, Z of player
        targetposition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        //Move the camera to the target position
        //Param: Vector3 a = current camera position, Vector3 b = the player location, float f = the amount of movement the camera can have in a single update frame
        transform.position = Vector3.Lerp(transform.position, targetposition, cameraSpeed * Time.deltaTime);
	}
}
