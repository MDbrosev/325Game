using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody2D enemyRigidBody;
    private bool moving;
    public float timeBetweenMovement;
    public float movementTime; //
    private Vector3 direction;
    private float counter0;
    private float counter1;
    public float reloadTime;
    private bool reload;
    private GameObject player;

	// Use this for initialization
	void Start ()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        //counter0 = timeBetweenMovement;
        //counter1 = movementTime;
        //maybe make min 0
        counter0 = Random.Range(timeBetweenMovement * 0.75f, timeBetweenMovement * 1.25f);
        counter1 = Random.Range(timeBetweenMovement * 0.75f, timeBetweenMovement * 1.25f);

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (moving)
        {
            counter1 -= Time.deltaTime;
            enemyRigidBody.velocity = direction;
            if(counter1 < 0f)
            {
                moving = false;
                counter0 = Random.Range(timeBetweenMovement * 0.75f, timeBetweenMovement * 1.25f);
            }
        }
        else
        {
            counter0 -= Time.deltaTime;
            enemyRigidBody.velocity = Vector2.zero;
            if(counter0 < 0f)
            {
                moving = true;
                counter1 = Random.Range(timeBetweenMovement * 0.75f, timeBetweenMovement * 1.25f);
                direction = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }
        }
        if (reload)
        {
            reloadTime -= Time.deltaTime;
            if(reloadTime < 0)
            {
                Application.LoadLevel(Application.loadedLevel);
                //as soon as it loads
                player.SetActive(true);
            }
        }
	}
    //player and enemy have 2d collision boxes, will use OnCollisionEnter2D to recoginize the collison between the two
    private void OnCollisionEnter2D(Collision2D collision)
    {
       /* if (collision.gameObject.name == "Player")
        {
            //dont want to destroy the player
            //Destroy(collision.gameObject);

            //set player condition to flase when hit by enemy
            collision.gameObject.SetActive(false);
            reload = true;
            player = collision.gameObject;
        }*/
    }
}
