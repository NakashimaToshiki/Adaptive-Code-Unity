using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(StatusModel))]
public class StatusModelInspector : Editor
{

    public override void OnInspectorGUI()
    {
        StatusModel script = target as StatusModel;

        script.HealthMax = EditorGUILayout.IntField(nameof(script.HealthMax), script.HealthMax);
        script.Health = EditorGUILayout.IntField(nameof(script.Health), script.Health);
    }
}
