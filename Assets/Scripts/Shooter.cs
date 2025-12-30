using UnityEngine;

//

public class Shooter : MonoBehaviour
{

    // Shooter Settings

    [Header("Shooter Settings")] [SerializeField]
    private float decal;

    [SerializeField] private float accel;
    [SerializeField] private float loadingSpeed = 1;

    [Space(10)]

    // Buttons Keys Objects

    [Header("Buttons Keys Objects")]
    [SerializeField]
    private KeyCode key = KeyCode.Space;

    [SerializeField] private Rigidbody rigidBody;

    // Bool Variables

    private bool _keyUp;
    private bool _push;
    private bool _canPush;

    //

    // Base Functions

    private void Update()
    {
        if (Input.GetKeyUp(key))
        {
            _keyUp = true;
            _canPush = false;
            _push = false;
        }

        if (_canPush && Input.GetKey(key))
        {
            _push = true;
        }
    }
}