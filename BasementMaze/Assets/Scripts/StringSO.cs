using System;
using UnityEngine;
[CreateAssetMenu]
public class StringSO : ScriptableObject {
    public string value;

    public void SetValue(String newValue) {
        value = newValue;
    }

    public void SetTextToString(TextMesh textMeshObj) {
        textMeshObj.text = value;
    }
}
