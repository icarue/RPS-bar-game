using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleTextScript : MonoBehaviour {
    Text score;
    public Enemy1Script enemy;
    string preferredTitle;
  

    // Use this for initialization
    void Start () {
        score = GetComponent<Text>();
        preferredTitle = enemy.choiceToString(enemy.preferredChoice);
        score.text = preferredTitle;
        

    }
	
	// Update is called once per frame
	void Update () {
      
        //string s = 10.ToString();
        //score.text = s;
		
	}
}
