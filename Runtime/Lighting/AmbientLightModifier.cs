using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySnippets
{
    [ExecuteInEditMode]
    [AddComponentMenu("Unity Snippets/Lighting/Ambient Lighting")]
    public class AmbientLightModifier : MonoBehaviour
    {
        [ColorUsage(false, true)] public Color ambientColor = Color.white;

        private void Update()
        {
            RenderSettings.ambientSkyColor = ambientColor;
        }
    }
}
