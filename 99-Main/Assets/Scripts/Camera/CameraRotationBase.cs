using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationBase : MonoBehaviour {
    
    virtual public float XValue { get { return 0; } }
    
    virtual public float YValue { get { return 0; } }

    private Vector3 angle;

    private static float max = 90;

    private static float min = -90;

    public virtual void Rotation()
    {
        angle += new Vector3(YValue, XValue, 0);

        if (angle.x > max)
        {
            angle.x = max;
        }
        else if (angle.x < min)
        {
            angle.x = min;
        }
        transform.localEulerAngles = angle;

    }
    
}
