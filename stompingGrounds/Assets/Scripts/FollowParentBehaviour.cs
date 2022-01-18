using UnityEngine;

public class FollowParentBehaviour : MonoBehaviour {
    private Transform _parentTransform;
    private Rigidbody _rb;
    private CalculateOffset _calculateOffset;
    public Vector3 _offset;
    private void Start() {
        _parentTransform = gameObject.transform.parent.transform;
        _rb = gameObject.GetComponent<Rigidbody>();
        _calculateOffset = gameObject.GetComponent<CalculateOffset>();
    }

    private void FixedUpdate() {
        if (_parentTransform == null) return;
        _offset = _calculateOffset.offsetVector;
        try {
            _rb.MovePosition(_parentTransform.position + _offset);
        }
        catch (MissingReferenceException e) {
            enabled = false;
            print(e);
            throw;
        }
    }
}
