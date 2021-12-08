using UnityEngine;
using Random = UnityEngine.Random;

public class SetBlobColor : MonoBehaviour {
    public BlobListSO blobArtList;
    public int colorID;

    private SpriteRenderer _spriteRenderer;
    private void Start() {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        colorID = RandomInt(blobArtList.blobArtSos.Capacity);
        var blobArt = blobArtList.blobArtSos[colorID].color;
        _spriteRenderer.color = blobArt;
    }

    private int RandomInt(int range) {
        return Random.Range(0, range);
    }
}

