using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MaterialOneColorModifier : MonoBehaviour
{
    [SerializeField] Material material = null;
    [SerializeField] string propertyName1 = "";
    [ColorUsage(true, true)]public Color propertyValue1 = Color.white;
    
    void Update()
    {
        if (material != null)
        {
            material.SetColor(propertyName1, propertyValue1);
        }
    }
}
