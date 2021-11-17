using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class RotateArtBehaviour : MonoBehaviour {
    private SpriteRenderer _spriteRenderer;

    private void Start() {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void RotateArt() {
        _spriteRenderer.transform.Rotate(Vector3.forward, -90);
    }
}
