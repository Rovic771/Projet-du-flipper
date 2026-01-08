using UnityEngine;

public class Tapis : MonoBehaviour
{
    [SerializeField] private GameObject Caisse;
    [SerializeField] private GameObject Ball;
    [SerializeField] private float VitesseTapis = 5f;
    private bool Surtapis = false;
    private bool BallSurTapis = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        Surtapis = true;
        BallSurTapis = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        Surtapis = false;
        BallSurTapis = false;
    }
    
    private void FixedUpdate()
    {
        if (Surtapis == true)
        {
            Caisse.transform.position += new Vector3(VitesseTapis, 0, 0) * Time.fixedDeltaTime;
        }

        if (BallSurTapis == true)
        {
            Ball.transform.position += new Vector3(VitesseTapis, 0, 0) * Time.fixedDeltaTime;
        }
    }
    
    public void PosInit()
    {
        Caisse.transform.position = new Vector3(-12,1,0.3f);
        Caisse.transform.rotation = Quaternion.Euler(-90, 0, 0);
    private void PosInit()
    {
        Caisse.transform.position = new Vector3(-4.8f, -6.5f, -3);
    }
}
