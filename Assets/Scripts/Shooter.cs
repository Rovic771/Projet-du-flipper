using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float decal;
    public float accel;
    public float loadingSpeed = 1;
    public KeyCode key          = KeyCode.Space;
    public Rigidbody test;
    
    public bool keyUp;
    public bool push;
    public bool canPush;

    void Update()
    {
        if (Input.GetKeyUp(key))
        {
            keyUp = true;

            canPush = false;
            push = false;
        }

        if (canPush && Input.GetKey(key))
        {
            push = true;
            Debug.Log("coucou");
        }
    }

    void FixedUpdate()
    {
        if (keyUp)
        {
            test.isKinematic = false;

            keyUp = false;
        }

        if (push)
        {
            test.isKinematic = false;

            if (transform.localPosition.y > decal)
            {
                //allows down movement

                test.linearVelocity += loadingSpeed * transform.up;
            }
            else
            {
                //constraint when push is true

                test.linearVelocity = Vector3.zero;
                test.isKinematic = true;
            }
        }
        else
        {
            if (transform.localPosition.y < 0)
            {
                //allows up movement

                test.linearVelocity += transform.up * accel;
            }
            else
            {
                //constraint when push is false

                test.isKinematic = true;
                transform.localPosition = Vector3.zero;

                canPush = true;
            }
        }
        
        transform.localPosition = new Vector3(0, transform.localPosition.y, 0);
        
    }
}