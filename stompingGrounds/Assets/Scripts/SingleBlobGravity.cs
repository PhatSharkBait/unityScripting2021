using System;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SingleBlobGravity : MonoBehaviour {
    public FloatData fallSpeed;
    public GameAction freezeCheck;
    public bool canMove;

    private Rigidbody _rigidbody;
    private Vector3 _downVector;
    private Vector3 _blobPosition;
    void Start() {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.isKinematic = false;
    }

    private void FixedUpdate() {
        if (!canMove) return;
        _downVector = Vector3.down * fallSpeed.value * Time.deltaTime;
        _rigidbody.velocity = _downVector;
    }

    public void SnapToGrid() {
        SetCanMove(false);
        _rigidbody.velocity = Vector3.zero;
        _blobPosition = gameObject.transform.position;
        _blobPosition = new Vector3(Mathf.Round(_blobPosition.x), Mathf.Round(_blobPosition.y), _blobPosition.z);
        gameObject.transform.position = _blobPosition;
        freezeCheck.Raise();
    }

    public void SetCanMove(bool value) {
        if (value) {
            gameObject.layer = 7;
        }
        else {
            gameObject.layer = 6;
            canMove = false;
        }
    }
}
