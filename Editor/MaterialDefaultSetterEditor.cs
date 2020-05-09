using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnitySnippets
{
    [CustomEditor(typeof(MaterialDefaultSetter), true)]
    public class MaterialDefaultSetterEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            MaterialDefaultSetter material = (MaterialDefaultSetter)target;
            if (GUILayout.Button("Set Default"))
            {
                material.Set();
            }
        }
    }
}

