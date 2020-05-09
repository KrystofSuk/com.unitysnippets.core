using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderNameTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent triggerEvent = null;

    [SerializeField] string onCollisionName = "";
    [SerializeField] bool onCollisonEnter = false;
    [SerializeField] bool onCollisonExit = false;
    [SerializeField] string onTriggerName = "";
    [SerializeField] bool onTriggerEnter = false;
    [SerializeField] bool onTriggerExit = false;

    private void OnCollisionEnter(Collision other)
    {
        if (onCollisionName == other.gameObject.name && onCollisonEnter)
            triggerEvent.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
        if (onCollisionName == other.gameObject.name && onCollisonExit)
            triggerEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (onTriggerName == other.gameObject.name && onTriggerEnter)
            triggerEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (onTriggerName == other.gameObject.name && onTriggerExit)
            triggerEvent.Invoke();
    }
}
