using System;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {
    [Range(-1f, 1f)] public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
    private static readonly int MainTex = Shader.PropertyToID("_MainTex");

    private void Start() {
        mat = gameObject.GetComponent<MeshRenderer>().material;
    }

    private void Update() {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset(MainTex, new Vector2(offset, 0));
    }
}
