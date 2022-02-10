using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour {
    public GameAction gameActionObj;
    public UnityEvent respondEvent;
    private void Awake() {
        gameActionObj.UnityActionObj += Respond;
    }

    private void Respond() {
        respondEvent.Invoke();
    }
}