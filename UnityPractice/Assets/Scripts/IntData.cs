using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject {
    public int value;

    public void UpdateValue(int addTo) {
        value += addTo;
    }

    public void SetValue(int newValue) {
        value = newValue;
    }
}
