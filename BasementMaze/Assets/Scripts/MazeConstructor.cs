using UnityEngine;

public class MazeConstructor : MonoBehaviour {
    public bool showDebug;

    [SerializeField] private Material mazeMat1;
    [SerializeField] private Material mazeMat2;
    [SerializeField] private Material startMat;
    [SerializeField] private Material treasureMat;
    [SerializeField] private Vector3 mazePosOffset;
    private MazeDataGenerator _dataGenerator;
    private MazeMeshGenerator _meshGenerator;

    
    public int[,] data {
        get; private set;
    }
    public float hallWidth {
        get; private set;
    }
    public float hallHeight {
        get; private set;
    }

    public int startRow {
        get; private set;
    }
    public int startCol {
        get; private set;
    }

    public int goalRow {
        get; private set;
    }
    public int goalCol {
        get; private set;
    }

    
    void Awake() {
        _meshGenerator = new MazeMeshGenerator();
        _dataGenerator = new MazeDataGenerator();
        // default to walls surrounding a single empty cell
        data = new int[,]
        {
            {1, 1, 1},
            {1, 0, 1},
            {1, 1, 1}
        };
    }
    
    public void GenerateNewMaze(int sizeRows, int sizeCols) {
        if (sizeRows % 2 == 0 && sizeCols % 2 == 0)
        {
            Debug.LogError("Odd numbers work better for dungeon size.");
        }

        data = _dataGenerator.FromDimensions(sizeRows, sizeCols);
        DisplayMaze();
    }
    
    //Simple visual representation to test mazes
    void OnGUI() {
        if (!showDebug) return;

        int[,] maze = data;
        int rMax = maze.GetUpperBound(0);
        int cMax = maze.GetUpperBound(1);

        string msg = "";

        for (int i = rMax; i >= 0; i--)
        {
            for (int j = 0; j <= cMax; j++)
            {
                if (maze[i, j] == 0)
                {
                    msg += "....";
                }
                else
                {
                    msg += "==";
                }
            }
            msg += "\n";
        }

        GUI.Label(new Rect(20, 20, 500, 500), msg);
    }
    
    private void DisplayMaze() {
        GameObject go = new GameObject();
        go.transform.position = Vector3.zero + mazePosOffset;
        go.name = "Procedural Maze";
        go.tag = "Generated";
        //Set To Ground Layer
        go.layer = 6;

        MeshFilter mf = go.AddComponent<MeshFilter>();
        mf.mesh = _meshGenerator.FromData(data);
    
        MeshCollider mc = go.AddComponent<MeshCollider>();
        mc.sharedMesh = mf.mesh;

        MeshRenderer mr = go.AddComponent<MeshRenderer>();
        mr.materials = new Material[2] {mazeMat1, mazeMat2};
    }
    
    public void DisposeOldMaze() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Generated");
        foreach (GameObject go in objects) {
            Destroy(go);
        }
    }
    
    private void FindStartPosition() {
        int[,] maze = data;
        int rMax = maze.GetUpperBound(0);
        int cMax = maze.GetUpperBound(1);

        for (int i = 0; i <= rMax; i++) {
            for (int j = 0; j <= cMax; j++) {
                if (maze[i, j] == 0) {
                    startRow = i;
                    startCol = j;
                    return;
                }
            }
        }
    }
    
    private void FindGoalPosition() {
        int[,] maze = data;
        int rMax = maze.GetUpperBound(0);
        int cMax = maze.GetUpperBound(1);

        // loop top to bottom, right to left
        for (int i = rMax; i >= 0; i--) {
            for (int j = cMax; j >= 0; j--) {
                if (maze[i, j] == 0) {
                    goalRow = i;
                    goalCol = j;
                    return;
                }
            }
        }
    }

}

