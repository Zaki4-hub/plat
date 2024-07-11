using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartY : MonoBehaviour
{
	public int LvlIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y  < -4.66f)
        {
        	SceneManager.LoadScene(LvlIndex);
        }
    }
}
