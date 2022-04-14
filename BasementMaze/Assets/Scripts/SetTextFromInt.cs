using UnityEngine;
using UnityEngine.UI;

public class SetTextFromInt : MonoBehaviour {
    private Text _textObj;

    public IntDataSO intDataSo;

    private void Start() {
        _textObj = gameObject.GetComponent<Text>();
    }

    public void SetTextFromIntData() {
        _textObj.text = intDataSo.value.ToString();
    }
}
