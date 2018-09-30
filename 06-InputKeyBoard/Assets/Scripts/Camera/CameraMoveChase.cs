using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveChase : CameraMoveBase
{

    override public Vector3 Value
    {
        get { return targetObject.transform.position - transform.position; }
    }

    public GameObject targetObject;

    // Update is called once per frame
    void Update()
    {
        base.Move();
    }
}
