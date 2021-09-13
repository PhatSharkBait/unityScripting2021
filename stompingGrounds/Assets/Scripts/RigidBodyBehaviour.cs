using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyBehaviour : MonoBehaviour {
    public float force;
    
    private Rigidbody _rb;
    private void Start() { 
        _rb = GetComponent<Rigidbody>();
        _rb.AddExplosionForce(force, Vector3.forward, 50f);
    }
}
