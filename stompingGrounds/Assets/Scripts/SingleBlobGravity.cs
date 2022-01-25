using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SingleBlobGravity : MonoBehaviour {
    public FloatData fallSpeed;
    public GameAction freezeCheck;
    public bool canMove;

    private Rigidbody _rigidbody;
    private Vector3 _downVector;
    private Vector3 _blobPosition;
    private bool isPaused = false;
    private void Start() {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.isKinematic = false;
    }

    private void FixedUpdate() {
        if (isPaused) return;
        if (!canMove) return;
        _downVector = Vector3.down * (fallSpeed.value * Time.deltaTime);
        _rigidbody.velocity = _downVector;
        //CheckBelow();
    }

    public void SnapToGrid() {
        _blobPosition = gameObject.transform.position;
        _blobPosition = new Vector3(Mathf.Round(_blobPosition.x), Mathf.Round(_blobPosition.y), _blobPosition.z);
        gameObject.transform.position = _blobPosition;
        _rigidbody.velocity = Vector3.zero;
        freezeCheck.Raise();
    }

    public void SetCanMove(bool value) {
        if (value) {
            gameObject.layer = 7;
            canMove = true;
        }
        else {
            gameObject.layer = 6;
            canMove = false;
        }
    }

    public void CheckBelow() {
        if (!CastDown()) return;
        SetCanMove(false);
        SnapToGrid();
    }

    private bool CastDown() {
        var origin = transform.position + Vector3.up * 0.1f;
        Debug.DrawRay(origin, Vector3.down, Color.green);
        return Physics.Raycast(origin, Vector3.down, 1f, 7);
    }

    private void OnCollisionEnter(Collision other) {
        SetCanMove(false);
        SnapToGrid();
    }
}
