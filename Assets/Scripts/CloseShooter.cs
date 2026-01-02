using UnityEngine;

public class CloseShooter : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject Ball;
    public bool DoorState = false;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            Door.SetActive(true);
        }
    }
    
    public void ResetLaPorte()
    {
        Door.SetActive(false);
    }
}
