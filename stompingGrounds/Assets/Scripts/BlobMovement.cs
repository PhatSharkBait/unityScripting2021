using UnityEngine;

public class BlobMovement : MonoBehaviour {
    private float _right;
    private void Update() {
        _right = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Horizontal")) {
            MoveRight(_right > 0);
        }
    }
    
    private void MoveRight(bool isRight) {
        if (isRight) {
            gameObject.transform.position += Vector3.right;
        }
        else {
            gameObject.transform.position += Vector3.left;
        }

    }
}