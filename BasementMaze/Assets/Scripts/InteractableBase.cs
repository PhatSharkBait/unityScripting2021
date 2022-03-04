using System;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public abstract class InteractableBase : MonoBehaviour {
    public StringSO StringSo;
    
    private float interactionRange = 2.5f;
    private SphereCollider rangeSphere;
    private bool inRange;
    private GameObject player;

    protected string interactionText = "default text";

    private void Start() {
        //Physics
        gameObject.layer = 10;
        rangeSphere = GetComponent<SphereCollider>();

        //get avg scale of object, divide interaction range by new scale
        var lossyScale = transform.lossyScale;
        var newScale = (Mathf.Abs(lossyScale.x) + Mathf.Abs(lossyScale.y) + Mathf.Abs(lossyScale.z))/3;
        Debug.Log(newScale);
        rangeSphere.radius = interactionRange/newScale;
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
        player = other.gameObject;
        StringSo.value = interactionText;
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
        player = null;
    }

    protected virtual void OnInteract() {
        throw new NotImplementedException();
    }
}
