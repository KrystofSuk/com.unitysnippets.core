using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent triggerEvent = null;

    [SerializeField] bool onStart = false;
    [SerializeField] bool onDestroy = false;
    [SerializeField] bool onEnable = false;
    [SerializeField] bool onDisable = false;

    private void Start() {   
        if(onStart)
            triggerEvent.Invoke();
    }

    private void OnDestroy() {
        if(onDestroy)
            triggerEvent.Invoke();
    }   

    private void OnEnable() {
        if(onEnable)
            triggerEvent.Invoke();
    }   

    private void OnDisable() {
        if(onDisable)
            triggerEvent.Invoke();
    }     
}
