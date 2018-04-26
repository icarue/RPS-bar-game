using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButtonScript : MonoBehaviour {
    public string musicName = "Music";
    public GameHandler handler;
    public Animator anim;
    bool on = false;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        //Debug.Log("Clicked on " + musicName);
        if (on == false && handler.playerChoice == handler.getChoice("none"))
        {
            //Debug.Log("Clicked while off");
            handler.playerChoice = GameHandler.choice.MUSIC;
            anim.SetBool("IsOn", true);
            on = true;
            handler.playerChose = true;
            return;
        }
        if (on)
        {
            //Debug.Log("Clicked while on");
            handler.playerChoice = GameHandler.choice.NONE;
            anim.SetBool("IsOn", false);
            on = false;
            handler.playerChose = false;
            handler.playerChoice = GameHandler.choice.NONE;
            return;
        }



    }
}
