using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameBehaviour : MonoBehaviour
{
    public void ReloadCurrentScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
