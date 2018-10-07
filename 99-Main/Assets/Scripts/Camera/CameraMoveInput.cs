using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveInput : CameraMoveBase
{
    public InputBase input;

    override public Vector3 Value
    {
        get { return  input.Move; }
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Value.x, 0, Value.y), transform);
        //base.Move();
    }
}
