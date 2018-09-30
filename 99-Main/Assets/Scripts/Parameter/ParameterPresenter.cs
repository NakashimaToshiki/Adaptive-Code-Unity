using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.ComponentModel;

public class ParameterPresenter : MonoBehaviour {

    public StatusModel model;

    public ParameterViewBase[] healthViews;

    void Awake()
    {
        model.PropertyChanged += Model_PropertyChanged;
        Model_PropertyChanged(model, new PropertyChangedEventArgs("")); // 開始時に値を発生させる用
    }

    private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        foreach (var view in healthViews)
        {
            view.SetParameter(model.HealthMax, model.Health);
        }
    }
}
