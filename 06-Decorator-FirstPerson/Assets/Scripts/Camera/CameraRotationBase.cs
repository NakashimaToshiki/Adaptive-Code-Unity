using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationBase : MonoBehaviour {
    
    virtual public float XValue { get { return 0; } }
    
    virtual public float YValue { get { return 0; } }

    public virtual void Rotation()
    {
        transform.localEulerAngles += new Vector3(YValue, XValue, 0);
    }
    
}
