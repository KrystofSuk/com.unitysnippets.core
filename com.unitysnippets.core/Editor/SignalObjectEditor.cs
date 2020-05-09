using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnitySnippets
{
    [CustomEditor(typeof(SignalObject), true)]
    public class SignalObjectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            SignalObject signal = (SignalObject)target;
            if (GUILayout.Button("Call Signal"))
            {
                signal.CallSignal();
            }
        }
    }
}
