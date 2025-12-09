using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    public void LoseBall()
    {
        Instantiate(Ball, new Vector3(2f, -0.2f, 1f), Quaternion.identity);
        Debug.Log("Lose Ball");
    }
}
