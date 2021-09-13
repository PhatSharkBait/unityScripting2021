using UnityEngine;
public class BallMove : MonoBehaviour {
    private Transform self;
    private GetMousePosition mousePositionScript;
    private Vector3 mousePos;
    private Vector3 selfPos;
    private void Start() {
        self = gameObject.transform;
        mousePositionScript = self.GetComponent<GetMousePosition>();
        mousePos = mousePositionScript.screenMousePos;
    }

    void Update() {
        mousePos = mousePositionScript.screenMousePos;
        selfPos = self.position;
        selfPos = new Vector3(mousePos.x, selfPos.y, selfPos.z);
        self.position = selfPos;
    }
}
