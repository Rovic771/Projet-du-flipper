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

    public GameObject Door;

    private Vector3 startPos;
    private bool isCharging = false;

    void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody>();
        startPos = transform.localPosition;
        
        rb.isKinematic = true; 
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(key))
        {
            isCharging = true;
            rb.isKinematic = true;
            
            float currentY = transform.localPosition.y;
            float targetY = startPos.y - maxPullDistance;
            
            if (currentY > targetY)
            {

                Vector3 newPos = transform.localPosition - (transform.up * loadingSpeed * Time.fixedDeltaTime);
                rb.MovePosition(transform.parent.TransformPoint(newPos));
            }
        }
        else if (isCharging) 
        {
            rb.isKinematic = false;
            isCharging = false;
            
            rb.AddForce(transform.up * shootForce, ForceMode.Impulse);
        }
        
        if (!isCharging && transform.localPosition.y >= startPos.y)
        {
            rb.linearVelocity = Vector3.zero;
            transform.localPosition = startPos;
            rb.isKinematic = true;
        }
    }
}