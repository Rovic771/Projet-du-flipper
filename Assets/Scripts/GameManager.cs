using System;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    [SerializeField] private LifeManager lifeManager;
    [SerializeField] private MenuManager menuManager;
    public void LoseBall()
    {
        lifeManager.LoseLife();
        if (lifeManager.NbLife >= 1)
        {
            Instantiate(Ball, new Vector3(8.8f,0.4f,1), Quaternion.identity);
            Debug.Log("Lose Ball"); 
            Debug.Log("NbLife: " + lifeManager.NbLife);
        }

    }

    public void GameOver()
    {
        if (lifeManager.NbLife <= 0)
        {
            menuManager.OpenGameOverMenu();
            Debug.Log("GameOver");
        }
    }

    public void Update()
    {
        GameOver();
    }
}
