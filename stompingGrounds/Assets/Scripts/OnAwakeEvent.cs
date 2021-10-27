using UnityEngine.Events;
using UnityEngine;
public class OnAwakeEvent : MonoBehaviour {
    public UnityEvent onAwakeEvent;
    private void Awake() {
        onAwakeEvent.Invoke();
    }
}
