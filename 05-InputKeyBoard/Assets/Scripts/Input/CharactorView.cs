using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorView : MonoBehaviour
{
    public CharacterController characterController;

    public InputBase inputBase;

    // 1.NavMeshによる移動に変更する
    // 2.カメラの向きに合わせて移動するようにする

    public void Move(Vector2 move)
    {
        characterController.Move(new Vector3(move.x, 0, move.y));
    }
}
