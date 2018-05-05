using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//get to next map
public class nextArea : MonoBehaviour
{
    public string level;

    private void OnTriggerEnter2D(Collider2D collision)
    {   //If player collides with the trigger, load next level
        if(collision.gameObject.name == "Player")
        {
            //This line is used to load the different scenes
            Application.LoadLevel(level);
            
        }
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
