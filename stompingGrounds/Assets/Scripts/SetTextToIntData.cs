using UnityEngine;
using UnityEngine.UI;

public class SetTextToIntData : MonoBehaviour {
    public IntData highscoreData;

    private Text _text;

    private void Awake() {
        _text = gameObject.GetComponent<Text>();
    }

    private void OnEnable() {
        _text.text = highscoreData.value.ToString();
    }
}
