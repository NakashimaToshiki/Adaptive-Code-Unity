using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationTouch : CameraRotationBase
{

    /// <summary>  </summary>
    override public float XValue { get { return Input.GetAxis("Mouse X"); } }

    /// <summary>  </summary>
    override public float YValue { get { return Input.GetAxis("Mouse Y"); } }

    void Update()
    {
        base.Rotation();
    }
}
