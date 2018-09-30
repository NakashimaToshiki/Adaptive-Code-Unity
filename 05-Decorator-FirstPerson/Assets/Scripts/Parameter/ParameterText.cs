using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParameterText : ParameterViewBase
{
    public Text valueText;

    override public void SetParameter(int max, int value)
    {
        valueText.text = value + " / " + max;
    }
}
