using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomMouse : CameraZoomBase
{
    public override float Value { get { return Input.GetAxis("Mouse ScrollWheel") * rate; } }

    public float rate = 8;

    void Update()
    {
        Zoom();
    }
}
