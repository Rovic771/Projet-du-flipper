using System;
using System.Collections;
using UnityEngine;

public class ValveScript : MonoBehaviour
{
    [SerializeField] private Animation ValveAnimation;
    [SerializeField] private GameObject Vapeur;
    [SerializeField] private GameObject Vapeur2;
    [SerializeField] private GameObject Vapeur3;
    [SerializeField] private float DureeParticule = 16f;

    private bool ValveActive = false;

    public void OnCollisionEnter(Collision other)
    {
        if (ValveActive == false)
        {
            if (other.gameObject.tag == "Ball")
            { 
                ValveAnimation.Play(); 
                Vapeur.SetActive(false);
                Vapeur.SetActive(true);
                Vapeur2.SetActive(false);
                Vapeur2.SetActive(true);
                Vapeur3.SetActive(false);
                Vapeur3.SetActive(true);
                StartCoroutine(DesactiverVapeur());
                ValveActive = true;
            }  
        }

        
    }

    IEnumerator DesactiverVapeur()
    {
        yield return new WaitForSeconds(DureeParticule);
        Vapeur.SetActive(false);
        Vapeur2.SetActive(false);
        Vapeur3.SetActive(false);
        ValveActive = false;
    }
}
