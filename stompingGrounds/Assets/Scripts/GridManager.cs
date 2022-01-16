using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private const int Columns = 6;
    private const int Rows = 12;

    public GameAction gridReady;
    public GameObject objectToSpawn;
    public Vector3 offset;

    private readonly List<GridData> _gridSpaces = new List<GridData>(72);
    private readonly List<List<GridData>> _allColumns = new List<List<GridData>>();
    
    private void Start() {
        GenerateGrid();
        GenerateColumns();
        //gridReady.Raise();
    }
    
    private void GenerateGrid() {
        int k = 0;
        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {
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
    

    private void GenerateColumns() {
        var totalSpaces = _gridSpaces.Count;
        int count = 0;
        int splitEvery = totalSpaces / 6;

        for (int i = splitEvery; i <= totalSpaces; i+= splitEvery) {
            var nextColumn = _gridSpaces.GetRange(count * splitEvery, splitEvery);
            _allColumns.Add(nextColumn);
            count++;
        }
    }


    public void HandleLandedPu() {
        while (true) {
            if (FindOccupiedSpaces()) {
                continue;
            }

            break;
        }
        
        CheckMatches();
    }


    private void CheckMatches() {
        print("I'll eventually match you boys up.");   
    }

    private bool FindOccupiedSpaces(){
        foreach (var space in _gridSpaces) {
            if (space.isOccupied) {
                foreach (var column in _allColumns) {
                    if (column.Contains(space)) {
                        FindHighestInColumn(column).SwapColor();
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private GridData FindHighestInColumn(List<GridData> column) {
        foreach (var space in column) {
            if (space.isOn == false) {
                return space;
            }
        }
        return null;
    }

}
