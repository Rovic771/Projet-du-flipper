using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    public void LoseBall()
    {
        Instantiate(Ball, new Vector3(8.8f,0.4f,1), Quaternion.identity);
        Debug.Log("Lose Ball");
    }
}
