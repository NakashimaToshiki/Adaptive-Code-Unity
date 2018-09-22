using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterBarView : MonoBehaviour
{

    public RectTransform valueRect;

    public void SetRate(int max, int value)
    {
        valueRect.localScale = new Vector3((float)value / max, 1, 1);
    }
}
