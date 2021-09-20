using System;
using UnityEngine;

public class CollectionBehaviour : MonoBehaviour {
    public CollectableSO collectedObj;
    public CollectionSO collection;

    private MeshRenderer mesh;
    private Collider collider;

    private void Start() {
        mesh = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();

        EnableDisableCollectable(!collectedObj.collected);
    }

    private void OnTriggerEnter(Collider other) {
        collection.Collect(collectedObj);
        EnableDisableCollectable(false);
    }

    private void EnableDisableCollectable(bool value) {
        mesh.enabled = value;
        collider.enabled = value;
    }
}
