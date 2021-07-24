using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistCheck : MonoBehaviour
{
    readonly string s = "HitCollider";

    public bool IsExist { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == s)
        {
            IsExist = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == s)
        {
            IsExist = false;
        }
    }
}
