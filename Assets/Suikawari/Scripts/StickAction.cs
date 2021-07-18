using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickAction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.TryGetComponent<IInteractable>(out var watermelon))
        {
            watermelon.Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<IInteractable>(out var watermelon))
        {
            watermelon.Interact();
        }
    }
}
