using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using System . Collections;
using System.Collections.Generic;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public Text finalScore;
    int myScore = 0;
   void Update()
    {
    scoreText.text = myScore.ToString();
    finalScore.text = "TOTAL SCORE:"+myScore.ToString();
    }
    public void AddScore (int score)
    {
        myScore += score;
    }
}
