using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private const int Columns = 6;
    private const int Rows = 12;

    public GameObject ObjectToSpawn;
    public Vector3 offset;

    private List<GameObject> _gridSpaces = new List<GameObject>(72);
    public GameObject newObject;

    private void GenerateGrid() {
        int k = 0;
        for (int i = 0; i < Columns; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                newObject = Instantiate(ObjectToSpawn, new Vector3(i, j, 0) + offset, Quaternion.identity).gameObject;
                newObject.GetComponent<GridData>().gridID = k;
                k++;
                _gridSpaces.Add(newObject);
                
            }
        }

        foreach (var space in _gridSpaces) {
            space.GetComponent<GridData>().GenerateNeighbors(_gridSpaces);
        }
    }

    private void Start()
    {
        GenerateGrid();
    }
}
