using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float Force = 10f;
    [SerializeField] int score = 10;
    [SerializeField] private Animation anim;
    private void OnCollisionEnter(Collision other)
    {
        Vector3 a = transform.position; ;
        Vector3 b = other.transform.position;
        Vector3 direction;
        direction = b - a;
        direction = direction.normalized;

        other.rigidbody.AddForce(direction * Force);

        ScoreManager.instance.AddScore(score);

        if (anim != null)
        {
            anim.Play();
        }

        
    }
}
