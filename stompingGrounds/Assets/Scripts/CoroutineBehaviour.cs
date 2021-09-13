using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour {
    public UnityEvent startEvent;
    public bool canRun = true;
    public float holdTime = 2f;

    private WaitForSeconds _wfs;
    
    private IEnumerator Start() {
        _wfs = new WaitForSeconds(holdTime);
        
        while (canRun) {
            yield return _wfs;
            print("HelloWorld");
            startEvent.Invoke();
        }
    }

}
