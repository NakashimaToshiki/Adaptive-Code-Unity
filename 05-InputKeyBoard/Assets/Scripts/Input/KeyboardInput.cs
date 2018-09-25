using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : InputBase
{
    public override Vector2 Move
    {
        get
        {
            Vector2 ret = new Vector2();
            if (Input.GetKey(KeyCode.W))
            {
                ret += new Vector2(0, 1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                ret += new Vector2(0, -1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                ret += new Vector2(-1, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                ret += new Vector2(1, 0);
            }
            return ret.normalized * 0.2f;
        }
    }

}
