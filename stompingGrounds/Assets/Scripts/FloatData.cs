using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject {
    public float value;
    
    public void AddToValue(float num) {
        value += num;
    }

    public void SetValue(float num) {
        value = num;
    }

    public void MultValue(float num) {
        value *= num;
    }

    public void DivValue(float num) {
        value /= num;
    }
}