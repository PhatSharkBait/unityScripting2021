using UnityEngine;

public class GridManager : MonoBehaviour
{
    private const int Columns = 6;
    private const int Rows = 12;

    public GameObject ObjectToSpawn;
    public Vector3 offset;

    private void generateGrid()
    {
        for (int i = 0; i < Columns; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                var newObject = Instantiate(ObjectToSpawn, new Vector3(i, j, 0) + offset, Quaternion.identity);
                newObject.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

    private void Start()
    {
        generateGrid();
    }
}
