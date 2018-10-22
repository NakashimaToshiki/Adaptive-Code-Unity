using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraParentThirdPerson : CameraParentBase
{

    public Vector3 _position;
    public override Vector3 Position { get { return _position; } }

    public CameraZoomBase cameraZoom;

    public void Active()
    {
        this.enabled = true;
        cameraZoom.enabled = true;
    }

    public void Passive()
    {
        this.enabled = false;
        cameraZoom.enabled = false;
    }
}
