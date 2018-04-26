using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoastButton : MonoBehaviour {

    public GameHandler handler;
    //public BoastAnimScpt anim;
    public Animator anim;
    bool on = false;


    public string BoastName = "Boast";

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }

    void OnMouseDown()
    {
       
        if (on == false && handler.playerChoice == handler.getChoice("none"))
        {
           
            handler.playerChoice = GameHandler.choice.BOAST;
            anim.SetBool("IsOn", true);
            on = true;
            handler.playerChose = true;
            return;
        }
        if (on)
        {
           
            handler.playerChoice = GameHandler.choice.NONE;
            anim.SetBool("IsOn", false);
            on = false;
            handler.playerChose = false;
            handler.playerChoice = GameHandler.choice.NONE;
            return;
        }


    }
}
