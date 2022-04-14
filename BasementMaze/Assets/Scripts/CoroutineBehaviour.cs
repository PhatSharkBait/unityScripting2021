using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour {
    public float delayTime;
    public UnityEvent delayEvent;

    private WaitForSeconds _waitForSeconds;

    private void Awake() {
        _waitForSeconds = new WaitForSeconds(delayTime);
    }

    private IEnumerator AfterDelayEvent() {
        yield return _waitForSeconds;
        delayEvent.Invoke();
    }

    public void BeginCoroutine() {
        StartCoroutine(AfterDelayEvent());
    }
}
