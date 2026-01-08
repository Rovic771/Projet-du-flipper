using System;
using UnityEngine;

public class ValveScript : MonoBehaviour
{
    [SerializeField] private GameObject Vavle;
    [SerializeField] private Animation ValveAnimation;

    public void OnCollisionEnter(Collision other)
    {
        ValveAnimation.Play();
    }
}
