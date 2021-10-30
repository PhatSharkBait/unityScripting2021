using System;
using UnityEngine;

public class FollowParentBehaviour : MonoBehaviour {
    private Transform _parentTransform;
    private Rigidbody _rb;
    private void Start() {
        _parentTransform = gameObject.transform.parent.transform;
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        try {
            _rb.MovePosition(_parentTransform.position);
        }
        catch (MissingReferenceException e) {
            enabled = false;
            throw;
        }
    }
}
