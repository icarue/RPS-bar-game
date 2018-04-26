using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

    public enum choice {FLIRT, BOAST, MUSIC, NONE};
    public choice playerChoice = choice.NONE;
    public bool playerChose = false;
    public choice preferredPlayerChoice = choice.NONE;

    public Enemy1Script enemy1;
    public Enemy2Script enemy2;

    public int playerFollowers;
    public int enemy1Followers;
    public int enemy2Followers;
    public int initFollowersForAll = 10;
    int loseFollowersBasic;
    int loseFollowersPro;

    public bool isRoundOver;

    // Use this for initialization
    void Start () {
        playerChoice = choice.NONE;
        playerFollowers = initFollowersForAll;
        enemy1Followers = initFollowersForAll;
        enemy2Followers = initFollowersForAll;
        loseFollowersBasic = initFollowersForAll / 4;
        loseFollowersPro = initFollowersForAll / 2;

    }
	
	// Update is called once per frame
	void Update () {
        if(playerChoice == choice.BOAST){
            Debug.Log("Player choose to boast");
        }
        if (playerChoice == choice.MUSIC)
        {
            Debug.Log("Player choose to music");
        }
        if (playerChoice == choice.FLIRT)
        {
            Debug.Log("Player choose to flirt");
        }

        if(playerChoice == choice.NONE)
        {
            enemy1.enemyChose1 = false;
            //enemy2.enemyChose = false;
        }


        if (isRoundOver)
        {
            resultForPlayerByEnemy();
            resultForEnemyByPlayer();
            Debug.Log("Players followers are " + playerFollowers);
            Debug.Log("Enemy1 followers are " + enemy1Followers);
            Debug.Log("Enemy2 followers are " + enemy2Followers);

            isRoundOver = false;
        }



    }
    // not used, plan for removal
    public choice getChoice( string str)
    {
        switch(str){
            case "flirt":
                return choice.FLIRT;
            //break;
            case "boast":
                return choice.BOAST;
            //break;
            case "music":
                return choice.MUSIC;
            //break;
            case "none":
                return choice.NONE;
                //break;

        }

        return choice.NONE;

    }
     
    // Make the calculations for the end of round for the player
    public void resultForPlayerByEnemy()
    {
        // enemy 1
        switch (playerChoice)
        {
            case choice.FLIRT:
                switch (enemy1.enemyChoice)
                {
                    case choice.FLIRT:
                        break;

                    case choice.MUSIC:
                        if (preferredPlayerChoice != choice.FLIRT)
                            playerFollowers += calculateFollowersBasicE1();
                        else
                            playerFollowers += calculateFollowersProE1();
                        break;

                    case choice.BOAST:
                        if (enemy1.preferredChoice != choice.BOAST)
                            playerFollowers -= calculateFollowersBasicE1();
                        else
                            playerFollowers -= calculateFollowersProE1();
                        break;
                }
                break;

            case choice.BOAST:
                switch (enemy1.enemyChoice)
                {
                    case choice.FLIRT:
                        if (preferredPlayerChoice != choice.BOAST)
                            playerFollowers += calculateFollowersBasicE1();
                        else
                            playerFollowers += calculateFollowersProE1();
                        break;

                    case choice.MUSIC:
                        if (enemy1.preferredChoice != choice.MUSIC)
                            playerFollowers -= calculateFollowersBasicE1();
                        else
                            playerFollowers -= calculateFollowersProE1();

                        break;

                    case choice.BOAST:
                        break;
                }
                break;
            case choice.MUSIC:
                switch (enemy1.enemyChoice)
                {
                    case choice.FLIRT:
                        if (enemy1.preferredChoice != choice.FLIRT)
                            playerFollowers -= calculateFollowersBasicE1();
                        else
                            playerFollowers -= calculateFollowersProE1();

                        break;

                    case choice.MUSIC:
          
                        break;

                    case choice.BOAST:
                        if (preferredPlayerChoice != choice.MUSIC)
                            playerFollowers += calculateFollowersBasicE1();
                        else
                            playerFollowers += calculateFollowersProE1();
                        break;
                }
                break;



        }
        // enemy 2
        switch (playerChoice)
        {
            case choice.FLIRT:
                switch (enemy2.enemyChoice)
                {
                    case choice.FLIRT:
                        break;

                    case choice.MUSIC:
                        if (preferredPlayerChoice != choice.FLIRT)
                            playerFollowers += calculateFollowersBasicE2();
                        else
                            playerFollowers += calculateFollowersProE2();
                        break;

                    case choice.BOAST:
                        if (enemy2.preferredChoice != choice.BOAST)
                            playerFollowers -= calculateFollowersBasicE2();
                        else
                            playerFollowers -= calculateFollowersProE2();
                        break;
                }
                break;

            case choice.BOAST:
                switch (enemy2.enemyChoice)
                {
                    case choice.FLIRT:
                        if (preferredPlayerChoice != choice.BOAST)
                            playerFollowers += calculateFollowersBasicE2();
                        else
                            playerFollowers += calculateFollowersProE2();
                        break;

                    case choice.MUSIC:
                        if (enemy2.preferredChoice != choice.MUSIC)
                            playerFollowers -= calculateFollowersBasicE2();
                        else
                            playerFollowers -= calculateFollowersProE2();

                        break;

                    case choice.BOAST:
                        break;
                }
                break;
            case choice.MUSIC:
                switch (enemy2.enemyChoice)
                {
                    case choice.FLIRT:
                        if (enemy2.preferredChoice != choice.FLIRT)
                            playerFollowers -= calculateFollowersBasicE2();
                        else
                            playerFollowers -= calculateFollowersProE2();

                        break;

                    case choice.MUSIC:

                        break;

                    case choice.BOAST:
                        if (preferredPlayerChoice != choice.MUSIC)
                            playerFollowers += calculateFollowersBasicE2();
                        else
                            playerFollowers += calculateFollowersProE2();
                        break;
                }
                break;



        }

    }


    public void resultForEnemyByPlayer ()
    {
        // enemy 1
        switch (playerChoice)
        {
            case choice.FLIRT:
                switch (enemy1.enemyChoice)
                {
                    case choice.FLIRT:
                        break;

                    case choice.MUSIC:
                        if (preferredPlayerChoice != choice.FLIRT)
                            enemy1Followers -= calculateFollowersBasicE1();
                        else
                            enemy1Followers -= calculateFollowersProE1();
                        break;

                    case choice.BOAST:
                        if (enemy1.preferredChoice != choice.BOAST)
                            enemy1Followers += calculateFollowersBasicE1();
                        else
                            enemy1Followers += calculateFollowersProE1();
                        break;
                }
                break;

            case choice.BOAST:
                switch (enemy1.enemyChoice)
                {
                    case choice.FLIRT:
                        if (preferredPlayerChoice != choice.BOAST)
                            enemy1Followers -= calculateFollowersBasicE1();
                        else
                            enemy1Followers -= calculateFollowersProE1();
                        break;

                    case choice.MUSIC:
                        if (enemy1.preferredChoice != choice.MUSIC)
                            enemy1Followers += calculateFollowersBasicE1();
                        else
                            enemy1Followers += calculateFollowersProE1();

                        break;

                    case choice.BOAST:
                        break;
                }
                break;

            case choice.MUSIC:
                switch (enemy1.enemyChoice)
                {
                    case choice.FLIRT:
                        if (enemy1.preferredChoice != choice.FLIRT)
                            enemy1Followers += calculateFollowersBasicE1();
                        else
                            enemy1Followers += calculateFollowersProE1();

                        break;

                    case choice.MUSIC:

                        break;

                    case choice.BOAST:
                        if (preferredPlayerChoice != choice.BOAST)
                            enemy1Followers -= calculateFollowersBasicE1();
                        else
                            enemy1Followers -= calculateFollowersProE1();

                        break;
                }
                break;



        }
        // enemy 2
        switch (playerChoice)
        {
            case choice.FLIRT:
                switch (enemy2.enemyChoice)
                {
                    case choice.FLIRT:
                        break;

                    case choice.MUSIC:
                        if (preferredPlayerChoice != choice.FLIRT)
                            enemy2Followers -= calculateFollowersBasicE2();
                        else
                            enemy2Followers -= calculateFollowersProE2();
                        break;

                    case choice.BOAST:
                        if (enemy2.preferredChoice != choice.BOAST)
                            enemy2Followers += calculateFollowersBasicE2();
                        else
                            enemy2Followers += calculateFollowersProE2();
                        break;
                }
                break;

            case choice.BOAST:
                switch (enemy2.enemyChoice)
                {
                    case choice.FLIRT:
                        if (preferredPlayerChoice != choice.BOAST)
                            enemy2Followers -= calculateFollowersBasicE2();
                        else
                            enemy2Followers -= calculateFollowersProE2();
                        break;

                    case choice.MUSIC:
                        if (enemy2.preferredChoice != choice.MUSIC)
                            enemy2Followers += calculateFollowersBasicE2();
                        else
                            enemy2Followers += calculateFollowersProE2();

                        break;

                    case choice.BOAST:
                        break;
                }
                break;

            case choice.MUSIC:
                switch (enemy2.enemyChoice)
                {
                    case choice.FLIRT:
                        if (enemy2.preferredChoice != choice.FLIRT)
                            enemy2Followers += calculateFollowersBasicE2();
                        else
                            enemy2Followers += calculateFollowersProE2();

                        break;

                    case choice.MUSIC:

                        break;

                    case choice.BOAST:
                        if (preferredPlayerChoice != choice.BOAST)
                            enemy2Followers -= calculateFollowersBasicE2();
                        else
                            enemy2Followers -= calculateFollowersProE2();

                        break;
                }
                break;



        }

    }

    //TODO 
    public void resultForEnemyByEnemy()
    {

    }

    // calculate the loss/gain for enemy1
    public int calculateFollowersBasicE1()
    {
        if (enemy1Followers > loseFollowersBasic)
        {
            return loseFollowersBasic;
        }
        else
        {
            return enemy1Followers;
        }
        
    }

    // calculate the loss/gain for enemy1
    public int calculateFollowersBasicE2()
    {
        if (enemy2Followers > loseFollowersBasic)
        {
            return loseFollowersBasic;
        }
        else
        {
            return enemy2Followers;
        }

    }

    public int calculateFollowersProE1()
    {
        if (enemy1Followers > loseFollowersBasic)
        {
            return loseFollowersPro;
        }
        else
        {
            return enemy1Followers;
        }

    }

    public int calculateFollowersProE2()
    {
        if (enemy2Followers > loseFollowersBasic)
        {
            return loseFollowersPro;
        }
        else
        {
            return enemy2Followers;
        }

    }




}
