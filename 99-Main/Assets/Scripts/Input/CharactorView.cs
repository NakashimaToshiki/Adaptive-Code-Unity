using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharactorView : MonoBehaviour // 今のところプレイヤー専用
{

    public Camera mainCamera;

    public Transform pointOfView;

    public Transform agentTarget;

    private void Update()
    {
        //pointOfView.rotation = mainCamera.transform.rotation;
        Vector3 f = Vector3.Scale(mainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        if(f != Vector3.zero)
        {
            pointOfView.forward = f;
        }
    }

    public void Move(Vector2 move)
    {
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        //Vector3 cameraForward = Vector3.Scale(mainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        //agentTarget.Translate(new Vector3(move.x, 0, move.y) * 10, mainCamera.transform);
        agentTarget.localPosition = new Vector3(move.x, 0, move.y) * 10;
    }
    
}
