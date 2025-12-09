using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI text;

    void Awake()
    {
        instance = this;
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        text.text = score.ToString();
    }
}
