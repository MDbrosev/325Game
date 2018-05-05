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

	// Use this for initialization
	void Start () {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        counter0 = timeBetweenMovement;
        counter1 = movementTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (moving)
        {
            counter1 -= Time.deltaTime;
            enemyRigidBody.velocity = direction;
            if(counter1 < 0f)
            {
                moving = false;
                timeBetweenMovement = movementTime;
            }
        }
        else
        {
            counter0 -= Time.deltaTime;
            enemyRigidBody.velocity = Vector2.zero;
            if(counter0 < 0f)
            {
                moving = true;
                counter1 = movementTime;
                direction = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }
        }
	}
}
