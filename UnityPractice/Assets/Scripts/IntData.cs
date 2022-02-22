using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject {
    public int value;
    public MethodOverloading methodOverloadingObj;

    public void UpdateValue(int addTo) {
        value += addTo;
        methodOverloadingObj.ChangeValue(1f);
    }

    public void SetValue(int newValue) {
        value = newValue;
    }
}
