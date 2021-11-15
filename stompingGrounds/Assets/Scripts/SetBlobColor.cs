using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SetBlobColor : MonoBehaviour {
    public BlobListSO blobArtList;

    private SpriteRenderer _spriteRenderer;
    private void Start() {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        var blobArt = blobArtList.blobArtSos[RandomInt(blobArtList.blobArtSos.Capacity)].color;
        _spriteRenderer.color = blobArt;
    }

    private int RandomInt(int range) {
        return Random.Range(0, range);
    }
}

