using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SetText : MonoBehaviour {
    public StringSO stringSo;
    
    private Text _targetTextObj;

    private void Awake() {
        _targetTextObj = gameObject.GetComponent<Text>();
    }

    private void Update() {
        _targetTextObj.text = stringSo.value;
    }
}
