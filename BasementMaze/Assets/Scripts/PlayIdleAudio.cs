using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(AudioSource))]
public class PlayIdleAudio : MonoBehaviour {
    public float waitMin = 2;
    public float waitMax = 7;
    public AudioClipArraySO clips;

    private AudioSource source;

    private void Awake() {
        source = gameObject.GetComponent<AudioSource>();
    }

    private void Start() {
        StartCoroutine(TryPlaySound());
    }

    private IEnumerator TryPlaySound() {
        var waitForSeconds = new WaitForSeconds(Random.Range(waitMin, waitMax));
        yield return waitForSeconds;
        if (RandomChance(.1f)) {
            var randomClip = clips.clips[Random.Range(0, clips.clips.Length - 1)];
            source.clip = randomClip;
            source.Play();
            yield return new WaitForSeconds(3f);
        }

        StartCoroutine(TryPlaySound());
    }

    private bool RandomChance(float percentChance) {
        var chance = Random.Range(0f, 1f);
        return chance < percentChance;
    }
}
