using UnityEngine;
using UnityEngine.Events;
public class TriggerEventsBehavior : MonoBehaviour {
    public UnityEvent triggerEnterEvent;
    private void OnTriggerEnter(Collider other) {
        triggerEnterEvent.Invoke();
    }
}
