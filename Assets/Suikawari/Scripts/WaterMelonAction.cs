using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMelonAction : MonoBehaviour, IInteractable
{
    [SerializeField]
    Rigidbody separatedCollider_L, separetedCollider_R;

    public void Interact()
    {
        separatedCollider_L.isKinematic = false;
        separetedCollider_R.isKinematic = false;
    }
}
