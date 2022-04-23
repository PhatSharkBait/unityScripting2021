using UnityEngine;

public class LimitFrameRate : MonoBehaviour {
    public int targetFrameRate = 30;

    private void Awake() {
        Application.targetFrameRate = targetFrameRate;
    }
}
