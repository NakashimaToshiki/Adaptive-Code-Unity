using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationMouse : CameraRotationBase
{
    override public float XValue { get { return Input.GetAxis("Mouse X"); } }
    
    override public float YValue { get { return Input.GetAxis("Mouse Y"); } }
    
}
