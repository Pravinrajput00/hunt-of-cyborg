using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Player_Collision data;

    private void Update()
    {
        scoreText.text = data.score.ToString();
    }
}
