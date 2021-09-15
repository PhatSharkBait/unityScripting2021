using System;
using UnityEngine;
using UnityEngine.Events;

public class ColliderEventsBehaviour : MonoBehaviour {
    public UnityEvent colliderEvent;

    private void OnCollisionEnter(Collision other) {
        colliderEvent.Invoke();
    }
}
