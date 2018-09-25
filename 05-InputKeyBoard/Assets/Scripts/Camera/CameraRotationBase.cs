using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationBase : MonoBehaviour {

    /// <summary>  </summary>
    virtual public float XValue { get { return 0; } }

    /// <summary>  </summary>
    virtual public float YValue { get { return 0; } }

    public void Rotation()
    {
        transform.localEulerAngles += new Vector3(YValue, XValue, 0);
        //transform.Rotate(new Vector3(YValue, XValue, 0)); // こっちだとカメラが斜めになる場合がある
    }
}
