using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPresenter : MonoBehaviour
{
    // http://tsubakit1.hateblo.jp/entry/2014/08/02/030919
    // https://docs.unity3d.com/ja/current/Manual/UnderstandingVectorArithmetic.html
    public CharactorView view;
    public KeyboardInput input; // これもViewの一部
    
    private void Update()
    {
        //Vector2.SignedAngle
        //input.Move
        view.Move(input.Move);
    }
}
