using UnityEngine;

[RequireComponent(typeof(MazeConstructor))]

public class GameController : MonoBehaviour {
    private MazeConstructor _mazeConstructor;
    void Start() {
        _mazeConstructor = GetComponent<MazeConstructor>();
        _mazeConstructor.GenerateNewMaze(15, 15);
    }

}
