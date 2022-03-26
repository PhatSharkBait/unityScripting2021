using UnityEngine;

public class CollectOnOverlap : MonoBehaviour {
    public GameAction collectAction;
    private void OnTriggerEnter(Collider other) {
        collectAction.RaiseAction();
        //TODO: Think of a better way to do this
        Destroy(gameObject.transform.parent.gameObject);
    }
}
