using UnityEngine;

public class Tapis : MonoBehaviour
{
    [SerializeField] private GameObject Caisse;
    [SerializeField] private float VitesseTapis = 5f;
    private bool Surtapis = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        Surtapis = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        Surtapis = false;
    }
    private void FixedUpdate()
    {
        if (Surtapis == true)
        {
            Caisse.transform.position += new Vector3(VitesseTapis, 0, 0) * Time.fixedDeltaTime;
        }
    }
    
    public void PosInit()
    {
        Caisse.transform.position = new Vector3(-8.5f,1,0.3f);
        Caisse.transform.rotation = Quaternion.Euler(-90, 0, 0);
    }
}
