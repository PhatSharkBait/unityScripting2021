using UnityEngine;
using UnityEngine.Events;

public class CircleBehaviour : MonoBehaviour {
    public UnityEvent startEvent;

    private void Start() {
        startEvent.Invoke();
    }
}
