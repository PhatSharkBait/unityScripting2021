using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class FadeToBlack : MonoBehaviour {
    public RawImage Image;

    private WaitForSeconds _waitForSeconds = new WaitForSeconds(.75f);
    private float fadeAmount = .1f;

    private void Start() {
        Image = gameObject.GetComponent<RawImage>();
    }

    public void StartFade() {
        StartCoroutine(Fade());
    }

    private IEnumerator Fade() {
        while (Image.color.a < 1) {
            yield return _waitForSeconds;
            Image.color = new Color(0, 0, 0, Image.color.a + fadeAmount);
        }
    }
}
