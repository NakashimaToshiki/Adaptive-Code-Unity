using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBase : MonoBehaviour
{

    virtual public Vector2 Move
    {
        get { return new Vector2(); }
    }
}