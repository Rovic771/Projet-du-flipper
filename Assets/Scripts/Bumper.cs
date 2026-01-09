using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float Force = 10f;
    [SerializeField] int score = 10;
    [SerializeField] private Animation anim;
    [SerializeField] string TypeBumper;

    // Ajoute une variable pour stocker le nom de l'animation qui tourne par défaut
    // D'après ta capture d'écran, elle s'appelle "Engrenage"
    [SerializeField] string NomAnimationIdle = "Engrenage"; 

    private void Start()
    {
        // Sécurité : On s'assure que ça tourne au début du jeu
        if(anim != null && !anim.isPlaying)
        {
            anim.Play(NomAnimationIdle);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Vector3 a = transform.position;
        Vector3 b = other.transform.position;
        Vector3 direction = (b - a).normalized;

        other.rigidbody.AddForce(direction * Force);
        ScoreManager.instance.AddScore(score);

        if (other.gameObject.tag == "Ball")
        {
            if (anim != null)
            {
                if (TypeBumper == "Engrenage")
                {
                    // 1. On coupe tout et on joue l'impact IMMEDIATEMENT
                    anim.Play("bumperEngrenage");

                    // 2. MAGIE : On dit à Unity "Dès que l'impact est fini, relance 'Engrenage'"
                    anim.PlayQueued(NomAnimationIdle);
                }
                else 
                {
                    // Pour les bumpers normaux
                    anim.Play();
                }
            }
        }
    }
}