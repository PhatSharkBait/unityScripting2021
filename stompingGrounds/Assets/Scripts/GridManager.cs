using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private const int Columns = 6;
    private const int Rows = 12;

    public GameObject ObjectToSpawn;
    public Vector3 offset;

    private List<GameObject> _gridSpaces;
    private GameObject newObject;

    private void GenerateGrid() {
        int k = 0;
        for (int i = 0; i < Columns; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                _gridSpaces.Add(Instantiate(ObjectToSpawn, new Vector3(i, j, 0) + offset, Quaternion.identity));
                //newObject = Instantiate(ObjectToSpawn, new Vector3(i, j, 0) + offset, Quaternion.identity);
                //newObject.GetComponent<GridData>().gridID = k;
                //k++;
                //print(newObject);
                //_gridSpaces.Add(newObject);
                
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
