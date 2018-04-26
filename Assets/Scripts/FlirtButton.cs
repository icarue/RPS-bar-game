using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlirtButton : MonoBehaviour {

    public string flirtName = "Flirt";
    public GameHandler handler;
    public Animator anim;
    bool on = false;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnMouseDown()
    {
       
        
        if (on == false && handler.playerChoice == handler.getChoice("none"))
        {
            
            handler.playerChoice = GameHandler.choice.FLIRT;
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
