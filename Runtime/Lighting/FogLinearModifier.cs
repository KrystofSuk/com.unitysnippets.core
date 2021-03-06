﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySnippets
{
    [ExecuteInEditMode]
    [AddComponentMenu("Unity Snippets/Lighting/Linear Fog")]
    public class FogLinearModifier : MonoBehaviour
    {
        [ColorUsage(false, true)] public Color fogColor = Color.white;
        public float fogStart = 10;
        public float fogEnd = 200;

        private void Update()
        {
            if (!RenderSettings.fog)
                RenderSettings.fog = true;
            RenderSettings.fogColor = fogColor;
            RenderSettings.fogStartDistance = fogStart;
            RenderSettings.fogEndDistance = fogEnd;
        }
    }
}
