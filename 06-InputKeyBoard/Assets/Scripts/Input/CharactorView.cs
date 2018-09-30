using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharactorView : MonoBehaviour // 今のところプレイヤー専用
{
    //public CharacterController characterController;

    public InputBase inputBase;

    public Camera mainCamera;

    public Transform pointOfView;

    public Transform agentTarget;

    public Vector2 Forward
    {
        get
        {
            var tmp = Vector3.Scale(mainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
            return new Vector2(tmp.x, tmp.z);
        }
    }

    private void Update()
    {
        pointOfView.rotation = mainCamera.transform.rotation;
    }

    public void Move(Vector2 move)
    {
        agentTarget.localPosition = new Vector3(move.x, 0, move.y) * 10;
    }

    // 1.NavMeshによる移動に変更する
    // 2.カメラの向きに合わせて移動するようにする

    /*
public void Move(Vector2 move)
{

    navAgent.destination = transform.position + new Vector3(move.x, 0, move.y);
    //navAgent.Move(new Vector3(move.x, 0, move.y));
    //characterController.Move(new Vector3(move.x, 0, move.y));
}*/
}
