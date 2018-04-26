using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roundOverText : MonoBehaviour {

    Text rot;
    public GameHandler handler;

    // Use this for initialization
    void Start () {
        rot = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (handler.isRoundOver)
        {
            rot.text = "Round is Over";
        }
        else
        {
            rot.text = "";
        }

		
	}
}
