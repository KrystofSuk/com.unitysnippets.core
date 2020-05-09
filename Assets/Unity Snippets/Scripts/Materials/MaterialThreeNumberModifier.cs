using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MaterialThreeNumberModifier : MonoBehaviour
{
    [SerializeField] Material material = null;
    [SerializeField] string propertyName1 = "";
    public float propertyValue1;
    [SerializeField] string propertyName2 = "";
    public float propertyValue2;
    [SerializeField] string propertyName3 = "";
    public float propertyValue3;
    
    void Update()
    {
        if (material != null)
        {
            material.SetFloat(propertyName1, propertyValue1);
            material.SetFloat(propertyName2, propertyValue2);
            material.SetFloat(propertyName3, propertyValue3);
        }
    }
}
