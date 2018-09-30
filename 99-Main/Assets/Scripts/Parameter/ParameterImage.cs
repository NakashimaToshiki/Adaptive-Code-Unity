using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParameterImage : ParameterViewBase
{
    public Image valueImage;

    override public void SetParameter(int max, int value)
    {
        var color = valueImage.color;
        valueImage.color = new Color(color.r, color.g, color.b, Mathf.Lerp(1, 0, (float)value / max));
    }
}