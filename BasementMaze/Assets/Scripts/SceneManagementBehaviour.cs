using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementBehaviour : MonoBehaviour {
    public String sceneToLoad;
    public void LoadAScene() {
        SceneManager.LoadScene(sceneToLoad);
    }
}
