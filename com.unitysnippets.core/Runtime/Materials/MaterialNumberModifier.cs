using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySnippets
{
    [ExecuteInEditMode]
    [AddComponentMenu("Unity Snippets/Materials/Number Modifier")]
    public class MaterialNumberModifier : MonoBehaviour
    {
        [SerializeField] Material material = null;
        [SerializeField] string propertyName1 = "";
        public float propertyValue1;
        [SerializeField] string propertyName2 = "";
        public float propertyValue2;
        [SerializeField] string propertyName3 = "";
        public float propertyValue3;
        [SerializeField] string propertyName4 = "";
        public float propertyValue4;
        [SerializeField] string propertyName5 = "";
        public float propertyValue5;

        void Update()
        {
            if (material != null)
            {
                material.SetFloat(propertyName1, propertyValue1);
                material.SetFloat(propertyName2, propertyValue2);
                material.SetFloat(propertyName3, propertyValue3);
                material.SetFloat(propertyName4, propertyValue4);
                material.SetFloat(propertyName5, propertyValue5);
            }
        }
    }
}
