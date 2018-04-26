﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFollowers : MonoBehaviour {
    Text followers;
    public GameHandler handler;

    // Use this for initialization
    void Start()
    {
        followers = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        int i = handler.playerFollowers;
        string str = i.ToString();
        followers.text = "Followers: " + str;

    }
}