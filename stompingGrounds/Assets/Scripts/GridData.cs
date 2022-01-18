using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GridData : MonoBehaviour {
    public int gridID;
    public List<GridData> neighbors = new List<GridData>();
    
    public void GenerateNeighbors(List<GridData> gridSpaces) {
        if (gridID != 11 && gridID != 23 && gridID != 35 && gridID != 47 && gridID != 59 && gridID != 71) {
            neighbors.Add(gridSpaces[gridID + 1]);
        }

        if (gridID != 0 && gridID != 12 && gridID != 24 && gridID != 36 && gridID != 48 && gridID != 60) {
            neighbors.Add(gridSpaces[gridID - 1]);
        }

        if (gridID < 60) {
            neighbors.Add(gridSpaces[gridID + 12]);
        }

        if (gridID > 11) {
            neighbors.Add(gridSpaces[gridID - 12]);
        }
    }
    
    
    public BlobListSO blobColorList;
    public int colorID = 0;
    public bool isOn = false;
    [FormerlySerializedAs("willSwap")] public bool isOccupied = false;

    private SpriteRenderer _spriteRenderer;
    private GameObject _swapTo;
    private BoxCollider _collider;

    private void Start() {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _collider = gameObject.GetComponent<BoxCollider>();
    }

    public void SwapColor() {
        var newID = _swapTo.GetComponent<SetBlobColor>().colorID;
        _spriteRenderer.color = blobColorList.blobArtSos[newID].color;
        colorID = newID;
        _spriteRenderer.enabled = true;
        isOn = true;
        isOccupied = false;
        Destroy(_swapTo);
        RecalculateColliders();
    }

    public void RemoveFromGrid() {
        _spriteRenderer.enabled = false;
        isOn = false;
        RecalculateColliders();
    }

    private void OnTriggerExit(Collider other) {
        isOccupied = false;
    }

    private void OnTriggerStay(Collider other) {
        if(isOn) return;
        isOccupied = true;
        _swapTo = other.gameObject;
    }

    private void RecalculateColliders() {
        if (isOn) {
            _collider.size = new Vector3(1f, 1f, .2f);
            _collider.isTrigger = false;
            gameObject.layer = 0;
        }
        else {
            _collider.size = new Vector3(.5f, .5f, .2f);
            _collider.isTrigger = true;
            gameObject.layer = 5;
        }
    }
    
}
