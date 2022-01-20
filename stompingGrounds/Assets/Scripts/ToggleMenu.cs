using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu : MonoBehaviour {
    public void TogglePauseMenu(GameObject obj) {
        obj.SetActive(!obj.activeSelf);
    }
}
