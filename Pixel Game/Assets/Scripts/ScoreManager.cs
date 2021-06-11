﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    public TextMeshProUGUI Marks;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) {

            instance = this;
        }
    }

    public void changeScore(int fruitValue) {
        //get coin value as a parameter

        score += fruitValue;
        Marks.text = "X" + score.ToString(); // add coin value after the 

    }
}
