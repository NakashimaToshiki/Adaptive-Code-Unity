using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

public class StatusPresenter : MonoBehaviour
{

    public StatusModel model;

    public ParameterBarView healthView;

    void Awake()
    {
        model.healthRP.Subscribe(a => { healthView.SetRate((float)a / model.healthMax); });
    }
}
