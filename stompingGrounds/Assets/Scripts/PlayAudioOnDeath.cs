using UnityEngine;

public class PlayAudioOnDeath : MonoBehaviour {
    public GameAction QueueAudio;

    public void PlayAudio() {
        QueueAudio.Raise();
    }
}
