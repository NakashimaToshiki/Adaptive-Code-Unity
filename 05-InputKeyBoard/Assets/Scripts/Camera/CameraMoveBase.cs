using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveBase : MonoBehaviour {

    virtual public Vector3 Value { get; }

    public void Move()
    {
        transform.position += Value;
    }
}
