using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterBar : ParameterViewBase
{
    public RectTransform valueRect;

    override public void SetParameter(int max, int value)
    {
        valueRect.localScale = new Vector3((float)value / max, 1, 1);
    }
}
