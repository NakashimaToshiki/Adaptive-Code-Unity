using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAcceptor : Acceptor
{
    public override void Accept(Visitor visitor)
    {
        transform.parent.Rotate(new Vector3(0, 90, 0));
    }
}
