using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialDefaultSetter : MonoBehaviour
{
    [SerializeField] Material targetMaterial = null;
    [SerializeField] Material defaultMaterial = null;

    private void Start() {
        Set();
    }

    public void Set(){
        targetMaterial.CopyPropertiesFromMaterial(defaultMaterial);
    }
}
