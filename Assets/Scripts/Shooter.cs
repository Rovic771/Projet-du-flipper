using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("Réglages")]
    public float maxPullDistance = 2f; // Distance max (ex: 2)
    public float loadingSpeed = 2f;    // Vitesse de recul
    public float shootForce = 20f;     // Puissance du tir
    public KeyCode key = KeyCode.Space;

    [Header("Composants")]
    public Rigidbody rb;

    private Vector3 startPos;
    private bool isCharging = false;

    void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody>();
        startPos = transform.localPosition; // On mémorise le point zéro
        
        // Setup initial
        rb.isKinematic = true; 
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        // 1. CHARGEMENT (On appuie)
        if (Input.GetKey(key))
        {
            isCharging = true;
            rb.isKinematic = true; // On prend le contrôle manuel

            // On calcule où on veut aller (vers le bas)
            // On utilise Vector3.down (ou -transform.up)
            float currentY = transform.localPosition.y;
            float targetY = startPos.y - maxPullDistance;

            // Si on est pas encore en bas, on descend
            if (currentY > targetY)
            {
                // On déplace le Rigidbody proprement sans physique
                Vector3 newPos = transform.localPosition - (transform.up * loadingSpeed * Time.fixedDeltaTime);
                rb.MovePosition(transform.parent.TransformPoint(newPos));
            }
        }
        // 2. TIR (On relâche)
        else if (isCharging) 
        {
            // On active la physique pour le tir !
            rb.isKinematic = false;
            isCharging = false;

            // On applique une IMPULSION (un coup sec, pas une accélération lente)
            rb.AddForce(transform.up * shootForce, ForceMode.Impulse);
        }

        // 3. BUTÉE (Retour position initiale)
        // Si le shooter dépasse sa position de départ vers le haut
        if (!isCharging && transform.localPosition.y >= startPos.y)
        {
            // On stop tout
            rb.linearVelocity = Vector3.zero;
            transform.localPosition = startPos;
            rb.isKinematic = true;
        }
    }
}