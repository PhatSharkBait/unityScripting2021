using UnityEngine;
[CreateAssetMenu]
public class StringData : ScriptableObject {
    public string value;

    public void UpdateTextString(string text) {
        value = text;
    }

    public void UpdateTextInt(int num) {
        value = num.ToString("0");
    }

}
