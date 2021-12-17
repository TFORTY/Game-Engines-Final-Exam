using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    int score;

    public static ScoreText Instance { get; private set; }

    private void Awake()
    {
        scoreText = GetComponent<Text>();
        Instance = this;
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
}