using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour {

    public GameHandler handler;

    //public bool playerReady = false;
    GameHandler.choice[] enemyChoices;
    public GameHandler.choice enemyChoice;// = GameHandler.choice.NONE;
    int sizeChoices = 10;
    string preferredChoiceString = "boast";
    public GameHandler.choice preferredChoice;
    public GameHandler.choice secondChoice;
    public GameHandler.choice thirdChoice;
    public bool enemyChose = true;

    public Enemy1Script enemy1;

    // Use this for initialization
    void Start()
    {
        enemyChoice = GameHandler.choice.NONE;
        //Fill half the array with the preferred choice; then fill the rest of the array with the other choices
        //preferredChoice = handler.getChoice(preferredChoiceString);
        enemyChoices = new GameHandler.choice[sizeChoices];
        for (int i = 0; i < sizeChoices / 2; i++)
        {
            enemyChoices[i] = preferredChoice;
        }
        float w = sizeChoices * (3f / 4f);

        int k = (int)w;


        for (int i = (sizeChoices / 2); i < k; i++)
        {
            enemyChoices[i] = GameHandler.choice.FLIRT;
        }
        for (int i = k; i < sizeChoices; i++)
        {
            enemyChoices[i] = GameHandler.choice.MUSIC;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (handler.playerChose && !enemyChose)
        {
            int enemyChoiceInt = Random.Range(0, sizeChoices);

            enemyChoice = enemyChoices[enemyChoiceInt];
            string str = choiceToString(enemyChoice);

           Debug.Log("Enemy2 Choose to " + str);
            enemyChose = true;
            // Make the followers outcome here, or around here
            //handler.playerChose = false;
            //handler.playerChoice = GameHandler.choice.NONE;

            handler.isRoundOver = true;
        }


    }

    public string choiceToString(GameHandler.choice choice)
    {
        switch (choice)
        {
            case GameHandler.choice.FLIRT:
                return "Flirt";
            case GameHandler.choice.BOAST:
                return "Boast";
            case GameHandler.choice.MUSIC:
                return "Music";
            case GameHandler.choice.NONE:
                return "None";

        }

        return "error";
    }


}
