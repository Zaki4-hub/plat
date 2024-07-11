using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl4MoveTrap : MonoBehaviour
{
    float dirX; 
    public float speedy = 0.5f;
	public float speed = 2f; 

	bool moveingRight;
	bool moveingUp;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -3f)
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

        if (transform.position.y > 2.376f ) 
        {
        	moveingUp = false;
        }
        else if (transform.position.y < 1.705f)
        {
        	moveingUp = true;
        }

        if (moveingRight && moveingUp) 
        {
        	transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y + speedy * Time.deltaTime);
        }
        else 
        {
        	transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y - speedy * Time.deltaTime);
        }

}
}