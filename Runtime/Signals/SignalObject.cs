using System;
using UnityEngine;

namespace UnitySnippets
{
    [CreateAssetMenu(fileName = "Signal", menuName = "Unity Snippets/Signal", order = 0)]
    public class SignalObject : ScriptableObject
    {
        public Action signalAction;
        public void CallSignal()
        {
            signalAction?.Invoke();
        }
    }
}