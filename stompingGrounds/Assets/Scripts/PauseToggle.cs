using UnityEngine;
using UnityEngine.UI;

public class PauseToggle : MonoBehaviour {
    public GameAction pauseAction;

    public void SwitchToggle(Toggle obj) {
        Time.timeScale = obj.isOn ? 0 : 1;
        pauseAction.Raise();
    }

    public void TimeOn() {
        Time.timeScale = 1;
    }
}