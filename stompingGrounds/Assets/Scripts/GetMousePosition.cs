using UnityEngine;
public class GetMousePosition : MonoBehaviour {
    public Camera mainCamera;
    public Vector3 mousePosition;
    private void Update() {
        if (Input.GetMouseButton(0)) {
            mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            print(Input.mousePosition);
            print(mousePosition);
        }
    }
}