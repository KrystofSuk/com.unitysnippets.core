using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalReciever : MonoBehaviour
{
    [SerializeField] SignalObject signal = null;
    [SerializeField] UnityEvent signalEvent = null;

    private void Awake() {
        if(signal == null){
            Debug.LogError("Missing Signal");
            return;
        }
        signal.signalAction += SignalRecieved;
    }

    private void SignalRecieved()
    {
        signalEvent.Invoke();
    }

    private void OnDestroy() {
        if(signal == null)
            return;
        signal.signalAction -= SignalRecieved;
    }
}
