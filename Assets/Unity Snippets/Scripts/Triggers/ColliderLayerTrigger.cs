using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Unity Snippets/Triggers/Collider Layer")]
public class ColliderLayerTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent triggerEvent = null;

    [SerializeField] LayerMask onCollisionMask = 0;
    [SerializeField] bool onCollisonEnter = false;
    [SerializeField] bool onCollisonExit = false;
    [SerializeField] LayerMask onTriggerMask = 0;
    [SerializeField] bool onTriggerEnter = false;
    [SerializeField] bool onTriggerExit = false;

    private void OnCollisionEnter(Collision other)
    {
        if ((onCollisionMask.value & 1 << other.gameObject.layer) == 1 << other.gameObject.layer && onCollisonEnter)
            triggerEvent.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
        if ((onCollisionMask.value & 1 << other.gameObject.layer) == 1 << other.gameObject.layer && onCollisonExit)
            triggerEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((onTriggerMask.value & 1 << other.gameObject.layer) == 1 << other.gameObject.layer && onTriggerEnter)
            triggerEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if ((onTriggerMask.value & 1 << other.gameObject.layer) == 1 << other.gameObject.layer && onTriggerExit)
            triggerEvent.Invoke();
    }
}
