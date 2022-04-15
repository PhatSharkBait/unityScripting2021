using UnityEngine;
using UnityEngine.UI;

public class SetTextFromInt : MonoBehaviour {
    private Text _textObj;

    public IntDataSO intDataSo;

    private void Awake() {
        _textObj = gameObject.GetComponent<Text>();
        SetTextFromIntData();
    }

    public void SetTextFromIntData() {
        _textObj.text = intDataSo.value.ToString() + " remain";
        if(intDataSo.value == 1){
            _textObj.text = intDataSo.value.ToString() + " remains";
        }
    }
}
