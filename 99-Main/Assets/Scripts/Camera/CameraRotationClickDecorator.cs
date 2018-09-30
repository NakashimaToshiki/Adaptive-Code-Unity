using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationClickDecorator : CameraRotationBase
{
    public CameraRotationBase decorator;

    public int buttonIndex = 1;

    public override void Rotation()
    {
        if (Input.GetMouseButton(buttonIndex))
        {
            decorator.Rotation();
        }
    }
}
