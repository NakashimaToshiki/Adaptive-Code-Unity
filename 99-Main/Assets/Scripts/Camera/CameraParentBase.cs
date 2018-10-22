using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraParentBase : MonoBehaviour
{

    public virtual Vector3 Position { get; }

    public virtual void Setup(GameObject childGame)
    {
        childGame.transform.parent = transform;
        childGame.transform.localRotation = Quaternion.identity;
        childGame.transform.localPosition = Position;
    }
}
