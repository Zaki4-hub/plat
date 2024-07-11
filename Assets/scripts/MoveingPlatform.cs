using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPlatform : MonoBehaviour
{
	float dirX; 
	public float speed = 2f; 

	bool moveingRight;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 1f)
        {
        	moveingRight = false;
        }
        else if (transform.position.x < -5f) 
        {
        	moveingRight = true;
        }
        else 
        {

        }

        if (moveingRight) 
        {
        	transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else 
        {
        	transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
