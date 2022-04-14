using UnityEngine;
[CreateAssetMenu]
public class IntDataSO : ScriptableObject {
    public int value;

    public void SetValue(int newValue) {
        value = newValue;
    }

    public void DecreaseValueByAmount(int amount) {
        value -= amount;
    }
    
    public void IncreaseValueByAmount(int amount) {
        value += amount;
    }
}
