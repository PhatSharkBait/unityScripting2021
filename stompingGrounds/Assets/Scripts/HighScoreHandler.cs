using UnityEngine;

public class HighScoreHandler : MonoBehaviour {
    public IntData currentScore;
    public IntData highScore;

    private void Start() {
        if (highScore.value < currentScore.value) {
            highScore.value = currentScore.value;
        }

        currentScore.value = 0;
    }
}
