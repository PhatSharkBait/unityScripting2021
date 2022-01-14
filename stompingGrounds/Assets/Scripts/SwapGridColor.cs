using UnityEngine;

public class SwapGridColor : MonoBehaviour {
    public BlobListSO blobColorList;
    public int colorID = 0;
    public bool canMatch = false;

    private SpriteRenderer _spriteRenderer;

    private void Start() {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void ChangeToColorID(int value) {
        if (value <= blobColorList.blobArtSos.Capacity) {
            _spriteRenderer.color = blobColorList.blobArtSos[value].color;
            colorID = value;
            _spriteRenderer.enabled = true;
            canMatch = true;
        }
        else {
            print("failed");
            RemoveFromGrid();
        }
    }

    public void RemoveFromGrid() {
        _spriteRenderer.enabled = false;
        canMatch = false;
    }
    
    
}
