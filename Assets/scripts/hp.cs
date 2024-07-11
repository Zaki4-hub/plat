using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
	public static int hpp = 3;
	public Text hptext; 
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        hptext.text = "hp: " + hpp.ToString();
    }
}
