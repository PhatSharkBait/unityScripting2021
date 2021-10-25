using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SingleBlobGravity : MonoBehaviour {
    public FloatData fallSpeed;

    private Rigidbody _rigidbody;
    private Vector3 _downVector;
    void Start() {
        gameObject.layer = 6;
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.isKinematic = false;
    }

    private void FixedUpdate() {
        _downVector = Vector3.down * fallSpeed.value * Time.deltaTime;
        _rigidbody.velocity = _downVector;
    }
}
