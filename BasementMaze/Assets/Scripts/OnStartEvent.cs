using UnityEngine;
using UnityEngine.Events;

public class OnStartEvent : MonoBehaviour {
    public UnityEvent startEvent;

    private void Start() {
        startEvent.Invoke();
    }
}