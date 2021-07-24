using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikaRandomMove : MonoBehaviour
{
    [SerializeField]
    Vector3 min, max;

    private void Awake()
    {
        var x = Random.Range(min.x, max.x);
        var z = Random.Range(min.z, max.z);

        transform.position = new Vector3(x, 0, z);
    }
}
