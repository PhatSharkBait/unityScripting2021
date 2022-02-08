using System;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(TextMesh))]
public abstract class InteractableBase : MonoBehaviour {
    private float interactionRange = 2.5f;
    private SphereCollider rangeSphere;
    private TextMesh _textMesh;
    private MeshRenderer _meshRenderer;
    private bool inRange;
    private GameObject player;

    protected string interactionText = "default text";

    private void Start() {
        //Physics
        gameObject.layer = 10;
        rangeSphere = GetComponent<SphereCollider>();
        rangeSphere.radius = interactionRange;
        rangeSphere.isTrigger = true;
        
        //Text
        _textMesh = gameObject.GetComponent<TextMesh>();
        _textMesh.text = interactionText;

        _meshRenderer = gameObject.GetComponent<MeshRenderer>();
        _meshRenderer.enabled = false;
    }

    private void Update() {
        if (inRange) {
            // Determine which direction to rotate towards
            Vector3 targetDirection = player.transform.position - transform.position;
            _textMesh.transform.rotation = Quaternion.LookRotation(targetDirection);
            if (Input.GetButtonDown("Fire1")) {
                OnInteract();
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        player = other.gameObject;
        OnRangeEnter();
    }

    private void OnTriggerExit(Collider other) {
        OnRangeExit();
    }

    protected virtual void OnRangeEnter() {
        inRange = true;
        _meshRenderer.enabled = true;
    }

    protected virtual void OnRangeExit() {
        inRange = false;
        player = null;
        _meshRenderer.enabled = false;
    }

    protected virtual void OnInteract() {
        throw new NotImplementedException();
    }
}
