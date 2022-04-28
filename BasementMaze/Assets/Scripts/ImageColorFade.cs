using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class ImageColorFade : MonoBehaviour {
    private RawImage _image;
    private WaitForSeconds _waitForSeconds;
    
    [Range(0f, 1f)] public float fadeDelay = .1f;
    
    public void FadeOut() {
        _image = gameObject.GetComponent<RawImage>();
        StartCoroutine(FadeCoroutine());
        _waitForSeconds = new WaitForSeconds(fadeDelay);
    }

    private IEnumerator FadeCoroutine() {
        if (!(_image.color.a >= 0)) yield break;
        var newValue = _image.color.a - .05f;
        _image.color = new Color(1, 1, 1, newValue);
        yield return _waitForSeconds;
        StartCoroutine(FadeCoroutine());
    }
}
