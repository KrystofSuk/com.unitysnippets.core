using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderTagTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent triggerEvent = null;

    [SerializeField] string onCollisionTag = "";
    [SerializeField] bool onCollisonEnter = false;
    [SerializeField] bool onCollisonExit = false;
    [SerializeField] string onTriggerTag = "";
    [SerializeField] bool onTriggerEnter = false;
    [SerializeField] bool onTriggerExit = false;

    private void OnCollisionEnter(Collision other)
    {
        if (onCollisionTag == other.gameObject.tag && onCollisonEnter)
            triggerEvent.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
        if (onCollisionTag == other.gameObject.tag && onCollisonExit)
            triggerEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (onTriggerTag == other.gameObject.tag && onTriggerEnter)
            triggerEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (onTriggerTag == other.gameObject.tag && onTriggerExit)
            triggerEvent.Invoke();
    }
}
