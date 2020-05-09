using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FogExponentionalModifier : MonoBehaviour
{
    [ColorUsage(false, true)] public Color fogColor = Color.white;
    public float fogDensity = 0.01f;

    private void Update() {
        if(!RenderSettings.fog)
            RenderSettings.fog = true;
        RenderSettings.fogColor = fogColor;
        RenderSettings.fogDensity = fogDensity;
    }
}
