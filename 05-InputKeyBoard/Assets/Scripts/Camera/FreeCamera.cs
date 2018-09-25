using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/// <summary> 自由移動カメラ </summary>
public class FreeCamera : MonoBehaviour
{
    /// <summary> メインカメラ </summary>
    new public Camera camera;

    /// <summary> メインカメラとその子に位置する、すべてのカメラ </summary>
    private Camera[] cameras;

    public CharacterController character;

    private Transform cameraTrans;

    private Transform root;

    private Transform cameraTarget;

    public Vector3 min;

    public Vector3 max;

    public float zoomLimit = 10f;

    /// <summary>  </summary>
    private float XValue { get { return Input.GetAxis("Mouse X"); } }

    /// <summary>  </summary>
    private float YValue { get { return Input.GetAxis("Mouse Y"); } }

    /// <summary>  </summary>
    void Awake()
    {
        root = transform;

        cameraTrans = camera.transform;

        // カメラを追従させるポイントを生成
        GameObject gameObject = new GameObject("CameraTarget");
        cameraTarget = gameObject.transform;
        cameraTarget.parent = root;
        cameraTarget.position = cameraTrans.position;
        cameraTarget.rotation = cameraTrans.rotation;

        List<Camera> list = new List<Camera>();
        SearchCamara(transform, list);
        cameras = list.ToArray();
    }

    private void SearchCamara(Transform trans, List<Camera> list)
    {
        foreach (Transform child in trans)
        {
            Camera c = child.GetComponent<Camera>();
            if (c != null) list.Add(c);
            SearchCamara(child, list);
        }
    }


    void Update()
    {

        if (Input.GetButton("Camera Rotation"))
        {
            root.Rotate(new Vector3(YValue, XValue, 0));
        }

        if (Input.GetButton("Camera Zoom"))
        {
            cameraTarget.localPosition = new Vector3(cameraTarget.localPosition.x, cameraTarget.localPosition.y, cameraTarget.localPosition.z + YValue / 10);
            Vector3 pos = cameraTarget.localPosition;

            if (pos.z > zoomLimit)
            {
                cameraTarget.localPosition = new Vector3(pos.x, pos.y, zoomLimit);
            }
            else if (pos.z < 0)
            {
                cameraTarget.localPosition = new Vector3(pos.x, pos.y, 0);
            }
        }

        if (Input.GetButton("Camera Move"))
        {
            character.Move(root.right * -XValue / 10);
            character.Move(root.up * YValue / 10);
        }

        if (Input.GetButton("Camera Pan"))
        {
            float val = Input.GetAxis("Camera Pan");
            foreach (Camera c in cameras)
            {
                c.fieldOfView -= val;
            }
        }

        if (Input.GetButton("Camera Slope"))
        {
            root.Rotate(new Vector3(0, 0, Input.GetAxis("Camera Slope")));
        }

        cameraTrans.position = Vector3.Slerp(cameraTrans.position, cameraTarget.position, 0.9f);
        cameraTrans.rotation = Quaternion.Slerp(cameraTrans.rotation, cameraTarget.rotation, 0.9f);
    }

    /// <summary> カメラ行動を停止（UI操作時で使う） </summary>
    public void Stop()
    {
        enabled = false;
    }

    /// <summary> カメラ行動を再開（UI操作時で使う） </summary>
    public void ReStart()
    {
        enabled = true;
    }

}
