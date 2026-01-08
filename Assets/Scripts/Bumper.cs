using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float Force = 10f;
    [SerializeField] int score = 10;
    [SerializeField] private Animation anim;
    [SerializeField] string TypeBumper;
    private void OnCollisionEnter(Collision other)
    {
        Vector3 a = transform.position; ;
        Vector3 b = other.transform.position;
        Vector3 direction;
        direction = b - a;
        direction = direction.normalized;

        other.rigidbody.AddForce(direction * Force);

        ScoreManager.instance.AddScore(score);

        if (other.gameObject.tag == "Ball")
        {
            if (anim != null)
            {
                anim.Play();
                if (TypeBumper == "Engrenage")
                {
                    anim.Play("bumperEngrenage");
                }
            }
        }


        
    }
}
