using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BlobController : MonoBehaviour {
    private Rigidbody _rigidbody;
    private WaitForFixedUpdate _waitForFixedUpdate;
    private bool _canMove = true;
    private Vector3 _movement;
    private float _speedMultiplier = 1;

    public GameAction detachAction;
    public GameAction rotateAction;
    public FloatData fallRate;

    private void Start() {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _waitForFixedUpdate = new WaitForFixedUpdate();
        StartCoroutine(LimitedCoroutine());
    }

    private void Update() {
        if (Input.GetButtonDown("Horizontal")) {
                if (Input.GetAxis("Horizontal") > 0) {
                    MoveRight();
                }
                else {
                    MoveLeft();
                }
        }

        if (Input.GetButtonDown("Vertical")) {
            _speedMultiplier = 3;
        }

        if (Input.GetButtonUp("Vertical")) {
            _speedMultiplier = 1;
        }

        if (!Input.GetButtonDown("Jump")) return;
        RotateAndOffset();
    }

    private IEnumerator LimitedCoroutine() {
        while (_canMove) {
            _movement = Vector3.down * (fallRate.value * _speedMultiplier * Time.deltaTime);
            _rigidbody.velocity = _movement;
            yield return _waitForFixedUpdate;
        }
    }
    
    private void MoveRight() {
       transform.Translate(Vector3.right, Space.World);
    }

    private void MoveLeft() {
        transform.Translate(Vector3.left, Space.World);
    }

    public void SetCanMove(bool value) {
        _canMove = value;
    }

    public void DetachChildren() {
        transform.DetachChildren();
        detachAction.Raise();
    }

    private void RotateAndOffset() {
        gameObject.transform.Rotate(Vector3.forward, 90f);
        gameObject.transform.Translate(.5f, -.5f, 0);
        rotateAction.Raise();
    }
}
