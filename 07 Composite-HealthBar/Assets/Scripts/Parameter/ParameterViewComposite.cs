using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ParameterViewComposite : ParameterViewBase
{
    public List<ParameterViewBase> children;

    [ContextMenu("AddComponentInChildren")]
    public void AddComponentInChildren()
    {
        gameObject.GetComponentsInChildren<ParameterViewBase>(children);
        children.Remove(this);
    }

    public override void SetParameter(int max, int value)
    {
        children.ToList().ForEach(child => child.SetParameter(max, value));
    }
}
