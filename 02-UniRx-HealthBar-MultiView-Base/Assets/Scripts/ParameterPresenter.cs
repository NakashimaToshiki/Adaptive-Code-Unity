using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

public class ParameterPresenter : MonoBehaviour
{

    public StatusModel model;

    public ParameterBar healthView;

    void Awake()
    {
        model.healthRP.Subscribe(value => { healthView.SetParameter(model.healthMax, value); });
    }
}
