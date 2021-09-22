using System;
using UnityEngine;

public class CollectionBehaviour : MonoBehaviour {
    public CollectableSO collectedObj;
    public CollectionSO collection;

    private MeshRenderer mesh;
    private Collider thisCollider;

    private void Start() {
        mesh = GetComponent<MeshRenderer>();
        thisCollider = GetComponent<Collider>();

        EnableDisableCollectable(!collectedObj.collected);
    }

    private void OnTriggerEnter(Collider other) {
        collection.Collect(collectedObj);
        EnableDisableCollectable(false);
    }

    private void EnableDisableCollectable(bool value) {
        mesh.enabled = value;
        thisCollider.enabled = value;
    }
}
