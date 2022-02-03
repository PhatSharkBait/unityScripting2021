using System;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public abstract class InteractableBase : MonoBehaviour {
    private float interactionRange = 1.5f;
    private SphereCollider rangeSphere;
    private bool inRange;

    protected string interactionText;

    private void Start() {
        gameObject.layer = 10;
        rangeSphere = GetComponent<SphereCollider>();
        rangeSphere.radius = interactionRange;
        rangeSphere.isTrigger = true;
    }

    private void Update() {
        if (inRange) {
            if (Input.GetButtonDown("Fire1")) {
                OnInteract();
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        OnRangeEnter();
    }

    private void OnTriggerExit(Collider other) {
        OnRangeExit();
    }

    protected virtual void OnRangeEnter() {
        inRange = true;
    }

    protected virtual void OnRangeExit() {
        inRange = false;
    }

    protected virtual void OnInteract() {
        throw new NotImplementedException();
    }
}
