using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraParentFirstPerson : CameraParentBase
{

    public Vector3 _position;
    public override Vector3 Position { get { return _position; } }
}
