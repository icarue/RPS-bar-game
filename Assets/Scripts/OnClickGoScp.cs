using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickGoScp : MonoBehaviour {

    public enum goTo {START, OPTIONS};
    public goTo ObjDestination;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if(ObjDestination == goTo.START)
        {
            SceneManager.LoadScene("BarGameGame", LoadSceneMode.Single);
        }

    }
}
