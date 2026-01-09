using System.Collections.Generic;
using UnityEngine;

public class Tapis : MonoBehaviour
{
    [SerializeField] private GameObject Caisse;
    [SerializeField] private float VitesseTapis = 5f;
    [SerializeField] CamionScript Camion;
    private List<GameObject> objetsSurTapis = new List<GameObject>();
    private bool Surtapis = false;
    private bool BallSurTapis = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!objetsSurTapis.Contains(other.gameObject))
        {
            objetsSurTapis.Add(other.gameObject);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        if (objetsSurTapis.Contains(other.gameObject))
        {
            objetsSurTapis.Remove(other.gameObject);
            Destroy(other.gameObject);
            Camion.NbCaisse += 1;
        }
    }

    private void FixedUpdate()
    {
        for (int i = objetsSurTapis.Count - 1; i >= 0; i--)
        {
            if (objetsSurTapis[i] != null)
            {
                objetsSurTapis[i].transform.position += new Vector3(VitesseTapis, 0, 0) * Time.fixedDeltaTime;
            }
            else
            {
                objetsSurTapis.RemoveAt(i);
            }
        }
    }

    public void PosInit()
    {
        Instantiate(Caisse, new Vector3(-11.5f, -3.6f, -0.5f), Quaternion.identity);
        //Caisse.transform.position = new Vector3(-12, 1, 0.3f);
        //Caisse.transform.rotation = Quaternion.Euler(-90, 0, 0);
        //Caisse.transform.position = new Vector3(-4.8f, -6.5f, -3);
    }
}