using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Unity Snippets/Lightning/Ambient Lightning")]
public class AmbientLightModifier : MonoBehaviour
{
    [ColorUsage(false, true)] public Color ambientColor = Color.white;

    private void Update() {
        RenderSettings.ambientSkyColor = ambientColor;
    }
}
