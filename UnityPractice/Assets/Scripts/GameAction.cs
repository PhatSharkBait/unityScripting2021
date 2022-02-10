using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject {
    public UnityAction UnityActionObj;
    
    public void RaiseAction() {
        UnityActionObj?.Invoke();
    }
}
