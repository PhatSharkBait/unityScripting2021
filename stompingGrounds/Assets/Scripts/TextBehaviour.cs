using System;
using UnityEngine;
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour {
    public Text label;

    private void Start() {
        label = GetComponent<Text>();
    }

    private void UpdateTextValue(IntData obj) {
        label.text = obj.value.ToString("0");
    }
}
