using UnityEngine;

public class VapeurEffet : MonoBehaviour
{
    [SerializeField] private float puissanceVapeur = 2000f;
    [SerializeField] private Vector3 directionPoussee = new Vector3(1, 0, 0);
    [SerializeField] public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody rb = other.attachedRigidbody;

            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero; 
                rb.angularVelocity = Vector3.zero;
                Vector3 directionFinale = directionPoussee.normalized;
                rb.AddForce(directionFinale * puissanceVapeur, ForceMode.Impulse);
                scoreManager.AddScore(25);
            }
        }
    }
}