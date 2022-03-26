using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayCollectAudio : MonoBehaviour {
    public AudioClip collectOne;
    public AudioClip collectAll;
    
    private AudioSource _audioSource;

    private void Awake() {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void SelectAudioThenPlay() {
        if (true) {
            PlaySelectedAudio(collectOne);
        }
    }

    private void PlaySelectedAudio(AudioClip selection) {
        _audioSource.clip = selection;
        _audioSource.Play();
    }
}
