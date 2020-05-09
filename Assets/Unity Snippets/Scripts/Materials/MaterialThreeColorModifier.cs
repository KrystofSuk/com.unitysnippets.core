using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MaterialThreeColorModifier : MonoBehaviour
{
    [SerializeField] Material material = null;
    [SerializeField] string propertyName1 = "";
    [ColorUsage(true, true)]public Color propertyValue1 = Color.white;
    [SerializeField] string propertyName2 = "";
    [ColorUsage(true, true)]public Color propertyValue2 = Color.white;
    [SerializeField] string propertyName3 = "";
    [ColorUsage(true, true)]public Color propertyValue3 = Color.white;
    
    void Update()
    {
        if (material != null)
        {
            material.SetColor(propertyName1, propertyValue1);
            material.SetColor(propertyName2, propertyValue2);
            material.SetColor(propertyName3, propertyValue3);
        }
    }
}
