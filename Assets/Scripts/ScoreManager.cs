using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] private Tapis TapisScript;

    void Awake()
    {
        instance = this;
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        text.text = score.ToString();
    }

    private void Update()
    {
        if (score >= 250)
        {
            score -= 250;
            TapisScript.PosInit();
            text.text = score.ToString();
        }
    }
}
