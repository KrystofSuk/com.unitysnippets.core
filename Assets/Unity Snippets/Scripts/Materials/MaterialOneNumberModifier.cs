using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MaterialOneNumberModifier : MonoBehaviour
{
    [SerializeField] Material material = null;
    [SerializeField] string propertyName1 = "";
    public float propertyValue1;
    
    void Update()
    {
        if (material != null)
        {
            material.SetFloat(propertyName1, propertyValue1);
        }
    }
}
