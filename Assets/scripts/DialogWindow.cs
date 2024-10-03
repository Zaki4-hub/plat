using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogWindow : MonoBehaviour
{
	private Transform NPCT;
	public float HEIGHT;
	public Text dialog;
	private bool started;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (started)
    	{
        transform.position = Camera.main.WorldToScreenPoint(NPCT.position);
        transform.position += Vector3.up * HEIGHT;
    	}
    }

    public void SetUpWindow(Transform NPCTransform)
    {
    	NPCT = NPCTransform;
    	started = true;
    }	
}
