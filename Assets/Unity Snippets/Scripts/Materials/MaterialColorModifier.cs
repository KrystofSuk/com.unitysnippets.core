using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MaterialColorModifier : MonoBehaviour
{
    [SerializeField] Material material = null;
    [SerializeField] string propertyName1 = "";
    [ColorUsage(true, true)]public Color propertyValue1 = Color.white;
    [SerializeField] string propertyName2 = "";
    [ColorUsage(true, true)]public Color propertyValue2 = Color.white;
    [SerializeField] string propertyName3 = "";
    [ColorUsage(true, true)]public Color propertyValue3 = Color.white;
    [SerializeField] string propertyName4 = "";
    [ColorUsage(true, true)]public Color propertyValue4 = Color.white;
    [SerializeField] string propertyName5 = "";
    [ColorUsage(true, true)]public Color propertyValue5 = Color.white;
    
    void Update()
    {
        if (material != null)
        {
            material.SetColor(propertyName1, propertyValue1);
            material.SetColor(propertyName2, propertyValue2);
            material.SetColor(propertyName3, propertyValue3);
            material.SetColor(propertyName4, propertyValue4);
            material.SetColor(propertyName5, propertyValue5);
        }
    }
}
