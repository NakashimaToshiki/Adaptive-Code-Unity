using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraParentAdapter : MonoBehaviour
{
    public CameraParentBase firstPerson;

    public CameraParentBase thirdPerson;

    public CameraParentBase adapter;

    public float Value { get { return Input.GetAxis("Mouse ScrollWheel"); } }

    private void Awake()
    {
        ThirdPerson();
    }

    [ContextMenu("FirstPerson")]
    public void FirstPerson()
    {
        adapter = firstPerson;
        adapter.Setup(gameObject);
    }

    [ContextMenu("ThirdPerson")]
    public void ThirdPerson()
    {
        adapter = thirdPerson;
        adapter.Setup(gameObject);
    }
}
