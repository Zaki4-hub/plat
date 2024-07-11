using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl5Saw : MonoBehaviour
{
    public float speed = 1f;

    bool Moveing;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0.761f)
        {
        	Moveing = false;
        }
        else if (transform.position.y < -0.543f)
        {
        	Moveing = true;
        }

        if (Moveing) 
        {
        	transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else 
        {
        	transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
