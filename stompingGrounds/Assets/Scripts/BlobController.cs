using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BlobController : MonoBehaviour {
    private CharacterController _controller;
    private WaitForFixedUpdate _waitForFixedUpdate;
    private bool _canMove = true;
    private Vector3 _movement;
    public float fallRate = 1f;

    private void Start() {
        _controller = gameObject.GetComponent<CharacterController>();
        _waitForFixedUpdate = new WaitForFixedUpdate();
        StartCoroutine(LimitedCoroutine());
    }

    private void Update() {
        if (_canMove) {
            if (Input.GetButtonDown("Horizontal")) {
                if (Input.GetAxis("Horizontal") > 0) {
                    MoveRight();
                }
                else {
                    MoveLeft();
                }
            }   
        }
    }

    private IEnumerator LimitedCoroutine() {
        while (_canMove) {
            _movement = Vector3.down * fallRate * Time.deltaTime;
            _controller.Move(_movement);
            yield return _waitForFixedUpdate;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer != 7) {
            _canMove = false;
        }
    }

    private void MoveRight() {
        _controller.Move(Vector3.right);
    }

    private void MoveLeft() {
        _controller.Move(Vector3.left);
    }
}
