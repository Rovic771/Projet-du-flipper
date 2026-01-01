using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] CloseShooter closeShooter;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        gameManager.LoseBall();
        closeShooter.ResetLaPorte();
    }
}

