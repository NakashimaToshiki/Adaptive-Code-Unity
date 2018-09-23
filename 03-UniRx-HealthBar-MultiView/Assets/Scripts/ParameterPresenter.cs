using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

public class ParameterPresenter : MonoBehaviour {

    public StatusModel model;

    public ParameterViewBase[] healthViews;

    void Awake()
    {
        foreach (var view in healthViews)
        {
            model.healthRP.Subscribe(value => { view.SetParameter(model.healthMax, value); });
        }
    }
}
