using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public CameraRotationBase cameraRotation;
    
    void Update()
    {
        cameraRotation.Rotation();
    }

}
