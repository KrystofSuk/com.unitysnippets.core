using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MaterialDefaultSetter), true)]
public class MaterialDefaultSetterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        MaterialDefaultSetter signal = (MaterialDefaultSetter)target;
        if(GUILayout.Button("Set Default"))
        {
            signal.Set();
        }
    }
}

