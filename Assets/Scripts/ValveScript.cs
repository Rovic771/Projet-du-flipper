using System;
using UnityEngine;

public class ValveScript : MonoBehaviour
{
    [SerializeField] private Animation ValveAnimation;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        { 
            ValveAnimation.Play(); 
        }
        
    }
}
