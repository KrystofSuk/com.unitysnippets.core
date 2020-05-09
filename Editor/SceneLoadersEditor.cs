using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnitySnippets
{
    [CustomEditor(typeof(SceneLoader), true)]
    public class SceneLoaderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            SceneLoader loader = (SceneLoader)target;
            if (GUILayout.Button("Load"))
            {
                loader.LoadScene();
            }
            if (GUILayout.Button("Activate"))
            {
                loader.ActivateScene();
            }
        }
    }


    [CustomEditor(typeof(AdditiveSceneLoader), true)]
    public class AdditiveSceneLoaderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            AdditiveSceneLoader loader = (AdditiveSceneLoader)target;
            if (GUILayout.Button("Load"))
            {
                loader.LoadScene();
            }
            if (GUILayout.Button("Activate"))
            {
                loader.ActivateScene();
            }
        }
    }
}



