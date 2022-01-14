using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class GridManager : MonoBehaviour
{
    private const int Columns = 6;
    private const int Rows = 12;

    public GameObject objectToSpawn;
    public Vector3 offset;

    private readonly List<GridData> _gridSpaces = new List<GridData>(72);

    private void GenerateGrid() {
        int k = 0;
        for (int i = 0; i < Columns; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                var newObject = Instantiate(objectToSpawn, new Vector3(i, j, 0) + offset, Quaternion.identity);
                var newObjectGridData = newObject.GetComponent<GridData>();
                newObjectGridData.gridID = k;
                k++;
                _gridSpaces.Add(newObjectGridData);
                
            }
        }

        foreach (var space in _gridSpaces) {
            space.GenerateNeighbors(_gridSpaces);
        }
    }

    private void Start()
    {
        GenerateGrid();
    }


    public void HandleLandedPu() {
        foreach (var space in _gridSpaces) {
            if (space.willSwap) {
                space.SwapColor();
            }
        }
    }
    public void CheckMatches() {
        print("I'll eventually match you boys up.");   
    }

}
