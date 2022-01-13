using System.Collections.Generic;
using UnityEngine;

public class GridData : MonoBehaviour {
    public int gridID;
    private List<GameObject> _neighbors = new List<GameObject>();

    public void GenerateNeighbors(List<GameObject> gridSpaces) {
        if (gridID != 11 && gridID != 23 && gridID != 35 && gridID != 47 && gridID != 59 && gridID != 71) {
            _neighbors.Add(gridSpaces[gridID + 1]);
        }

        if (gridID != 0 && gridID != 12 && gridID != 24 && gridID != 36 && gridID != 48 && gridID != 60) {
            _neighbors.Add(gridSpaces[gridID - 1]);
        }

        if (gridID < 60) {
            _neighbors.Add(gridSpaces[gridID + 12]);
        }

        if (gridID > 11) {
            _neighbors.Add(gridSpaces[gridID - 12]);
        }
    }
}
