using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Acceptor : MonoBehaviour
{
    public abstract void Accept(Visitor visitor);
}
