using UnityEngine;
public class BallMove : MonoBehaviour {
    private Transform self;
    private Vector3 selfPos;
    public FloatData xFloatData;
    private void Start() {
        self = gameObject.transform;
    }

    void Update() {
        selfPos = self.position;
        selfPos = new Vector3(xFloatData.value, selfPos.y, selfPos.z);
        self.position = selfPos;
    }
}
