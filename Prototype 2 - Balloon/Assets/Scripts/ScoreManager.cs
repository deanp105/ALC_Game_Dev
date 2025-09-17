using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro; // include the UI text mesh pro namespace

public class ScoreManager : MonoBehaviour
{
    public int score; // keep track of score
    public TextMeshProUGUI scoreText; // reference Text UI object to display and update

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; // increase score by amount
        UpdateScoreText(); // update score UI text
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount; // decrease score by amount
        UpdateScoreText(); // update score UI text
    }
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}

