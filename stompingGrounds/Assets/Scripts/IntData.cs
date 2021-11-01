using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject {
    public int value;

    public void AddToValue(int num) {
        value += num;
    }
    public void LoopThroughFour(int num) {
        value += num;
        if (value > 3) {
            value = 0;
        }
    }
}
