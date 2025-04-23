using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("Door");
        }
    }
}
