using UnityEngine;
[CreateAssetMenu]
public class MethodOverloading : ScriptableObject {
    public void ChangeValue(int intNum) {
        var newNum = intNum + 2;
    }

    public void ChangeValue(float floatNum) {
        var newNum = floatNum + 10.5f;
    }
    
    public void ChangeValue(int intNum, float floatNum) {
        float newNum = intNum + 2;
        newNum = floatNum * newNum;
    }
}
