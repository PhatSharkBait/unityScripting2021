using UnityEngine;
using UnityEngine.Events;

public class OnAwakeEvent : MonoBehaviour {
    public UnityEvent awakeEvent;

    private void Awake() {
        awakeEvent.Invoke();
    }
}
