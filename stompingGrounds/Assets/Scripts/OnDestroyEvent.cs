using UnityEngine;
using UnityEngine.Events;

public class OnDestroyEvent : MonoBehaviour {
    public UnityEvent onDestroyEvent;

    private void OnDestroy() {
        onDestroyEvent.Invoke();
    }
}
