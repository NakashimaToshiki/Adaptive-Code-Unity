using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomBase : MonoBehaviour
{
    public virtual float Value { get; }

    public float zoomLimit = -10f; // 

    public void Zoom()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + Value);
        Vector3 pos = transform.localPosition;

        if (pos.z < zoomLimit)
        {
            transform.localPosition = new Vector3(pos.x, pos.y, zoomLimit);
        }
        else if (pos.z > 0)
        {
            transform.localPosition = new Vector3(pos.x, pos.y, 0);
        }
    }
}
