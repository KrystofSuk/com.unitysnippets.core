using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnitySnippets
{
    [AddComponentMenu("Unity Snippets/Triggers/Collider")]
    public class ColliderTrigger : MonoBehaviour
    {
        [SerializeField] UnityEvent triggerEvent = null;

        [SerializeField] bool onCollisonEnter = false;
        [SerializeField] bool onCollisonExit = false;
        [SerializeField] bool onTriggerEnter = false;
        [SerializeField] bool onTriggerExit = false;

        private void OnCollisionEnter(Collision other)
        {
            if (onCollisonEnter)
                triggerEvent.Invoke();
        }

        private void OnCollisionExit(Collision other)
        {
            if (onCollisonExit)
                triggerEvent.Invoke();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (onTriggerEnter)
                triggerEvent.Invoke();
        }

        private void OnTriggerExit(Collider other)
        {
            if (onTriggerExit)
                triggerEvent.Invoke();
        }
    }
}
