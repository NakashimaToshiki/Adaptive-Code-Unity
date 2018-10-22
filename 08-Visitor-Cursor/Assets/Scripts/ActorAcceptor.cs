using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorAcceptor : Acceptor
{
    public GameObject text;

    public override void Accept(Visitor visitor)
    {
        text.SetActive(true);
    }
}
