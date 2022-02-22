using UnityEngine;
[CreateAssetMenu]
public class MethodOverloading : ScriptableObject {
    public void ChangeValue(int num) {
        var newNum = num + 2;
    }

    public void ChangeValue(float num) {
        var newNum = num + 10.5f;
    }
}
