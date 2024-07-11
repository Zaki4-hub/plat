using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public float speed = 2f;
	public float jumpforce = 5f;
	Rigidbody2D rb;
	SpriteRenderer sr;
	public Animator animator;
    public Joystick Joystick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float verticalMove = Joystick.Vertical;
        float movement = Joystick.Horizontal; 
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

        animator.SetFloat("HorizontalMove", Mathf.Abs(movement));

        if (verticalMove >= 0.5f && Mathf.Abs(rb.velocity.y) < 0.05f) 
        {
        	rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }

        sr.flipX = movement < 0 ? true : false;

    }
}
