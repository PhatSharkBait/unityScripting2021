using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallBouncy : MonoBehaviour {
    private Rigidbody _rigidbody;
    public float impulseAmount;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Bounce(){
        _rigidbody.AddForce(0, impulseAmount, 0, ForceMode.Impulse);
    }
}
