using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Signal", menuName = "Unity Snippets/Signal", order = 0)]
public class SignalObject : ScriptableObject {
    public Action signalAction;
    public void CallSignal(){
        signalAction?.Invoke();
    }
}
