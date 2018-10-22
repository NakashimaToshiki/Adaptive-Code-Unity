using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtRotation : MonoBehaviour
{
    public LookAtPoint atPoint;

    private void Update()
    {
        transform.LookAt(atPoint.transform);
        Vector3 f = Vector3.Scale(transform.forward, new Vector3(1, 0, 1)).normalized;
        if (f != Vector3.zero)
        {
            transform.forward = f;
        }
    }
}
