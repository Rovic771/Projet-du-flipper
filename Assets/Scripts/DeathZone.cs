using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        gameManager.LoseBall();
    }
}

