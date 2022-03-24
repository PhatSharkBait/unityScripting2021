using UnityEngine;
using UnityEngine.Playables;

public class PlayStopAnimation : MonoBehaviour {
    private PlayableDirector _director;

    private void Awake() {
        _director = gameObject.GetComponent<PlayableDirector>();
    }

    private void OnTriggerEnter(Collider other) {
        _director.Play();
    }

    private void OnTriggerExit(Collider other) {
        _director.Pause();
    }
}
