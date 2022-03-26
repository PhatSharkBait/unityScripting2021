using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject {
    public UnityAction Raise;

    public void RaiseAction() {
        Raise.Invoke();
    }
}
