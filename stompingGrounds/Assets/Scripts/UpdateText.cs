using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour {
    public StringData stringData;
    private Text _text;
    private void Start() {
        _text = gameObject.GetComponent<Text>();
    }

    public void Update() {
        if (_text.text != stringData.value) {
            _text.text = stringData.value;
        }
    }
}
