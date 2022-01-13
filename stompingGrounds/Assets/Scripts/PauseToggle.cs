using UnityEngine;
using UnityEngine.UI;

public class PauseToggle : MonoBehaviour {

    public void SwitchToggle(Toggle obj) {
        Time.timeScale = obj.isOn ? 0 : 1;
    }
}
