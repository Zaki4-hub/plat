using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw5lvlend : MonoBehaviour
{
	public float speed; 

	bool Moveing; 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 1.5f)
        {
        	Moveing = true;
        }
        else if (transform.position.x > 3.25f)
        {
        	Moveing = false; 
        }

        if (Moveing) 
        {
        	transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else 
        {
        	transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
