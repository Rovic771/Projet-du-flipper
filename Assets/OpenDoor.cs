using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private Animation DoorAnimation;

    private void OnTriggerEnter(Collider other)
    {
        if (DoorAnimation != null)
        {
            DoorAnimation.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
