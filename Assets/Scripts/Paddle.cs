using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] HingeJoint hingeJoint;
    [SerializeField] KeyCode key = KeyCode.Space;

    [SerializeField] float targetPosition = 75f;
    [SerializeField] float originPosition;

    JointSpring jointSpring;

    void Start()
    {
        jointSpring = hingeJoint.spring;
    }

    void Update()
    {
        if (Input.GetKey(key))
        {
            jointSpring.targetPosition = targetPosition;
        }
        else
        {
            jointSpring.targetPosition = originPosition;
        }


        hingeJoint.spring = jointSpring;
    }
}