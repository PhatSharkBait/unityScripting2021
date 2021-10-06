using UnityEngine;
[CreateAssetMenu]
public class BoolData : ScriptableObject {
    public bool value;

    public void SetValue(bool newBool) {
        value = newBool;
    }

    public void ToggleValue() {
        value = !value;
    }
}
