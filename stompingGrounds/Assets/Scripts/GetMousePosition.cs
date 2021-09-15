using UnityEngine;
public class GetMousePosition : MonoBehaviour {
    public Camera mainCamera;
    public FloatData xFloatData;
    private void Update() {
        if (Input.GetMouseButton(0)) {
            var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5f);
            xFloatData.value = mainCamera.ScreenToWorldPoint(mousePos).x;
        }
    }
}