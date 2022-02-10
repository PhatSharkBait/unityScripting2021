using UnityEngine;

public class RotateUpdate : MonoBehaviour {
    public float angle = 2f;
    void Update() {
        gameObject.transform.Rotate(Vector3.up, angle);
    }
}
