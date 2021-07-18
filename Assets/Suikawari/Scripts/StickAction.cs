using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickAction : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<IInteractable>(out var watermelon))
        {
            watermelon.Interact();
            rb.isKinematic = true;
        }
    }
}
