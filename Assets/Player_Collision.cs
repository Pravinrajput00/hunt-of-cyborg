using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public int score=0;
    public Text scoreText;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("DragonBall"))
        {
            score += 1;
        }
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
