using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(TextMesh))]
public class ScaleToFitView : MonoBehaviour {
    public bool canScale;
    public float scaleFactor = .0001f;
    
    private Camera _firstPersonCamera;
    private Rect _safeArea;
    private MeshRenderer _meshRenderer;
    private Bounds _bounds;
    private TextMesh _textMesh;
    private void Awake() {
        _firstPersonCamera = Camera.main;
        _meshRenderer = gameObject.GetComponent<MeshRenderer>();
        _bounds = _meshRenderer.bounds;
        _textMesh = gameObject.GetComponent<TextMesh>();
    }

    private void Update() {
        _safeArea = _firstPersonCamera.pixelRect;
        if (canScale) {
            if (!PointInSafeArea(_bounds.min) || !PointInSafeArea(_bounds.max)) {
                ScaleDown();
            }
            else {
                ScaleUp();
            }
        }
    }

    private bool PointInSafeArea(Vector3 pointToCheck) {
        var screenPoint = _firstPersonCamera.WorldToScreenPoint(pointToCheck);
        return screenPoint.x > _safeArea.xMin && screenPoint.y > _safeArea.yMin && screenPoint.x < _safeArea.xMax && screenPoint.y < _safeArea.yMax;
    }

    private void ScaleDown() {
        transform.localScale -= Vector3.one * scaleFactor;
    }
    
    private void ScaleUp() {
        transform.localScale += Vector3.one * scaleFactor;
    }

}
