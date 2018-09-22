using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterBarView : MonoBehaviour
{

    public RectTransform valueRect;

    public void SetRate(float rate)
    {
        valueRect.localScale = new Vector3(rate, 1, 1);
    }
}
