using System.Collections.Generic;
using UnityEngine;

public class CheckNeighbors : MonoBehaviour {
    private Vector3[] _dir;

    public int groupCount;
    public bool readyToDelete = false;
    public List<GameObject> groupToDelete;
    public int colorID;

    private void Start() {
        groupToDelete = new List<GameObject> {gameObject};
        colorID = gameObject.GetComponent<SetBlobColor>().colorID;
        groupCount = 1;
    }

    public void CheckInDirection() {
        _dir = new []{Vector3.up, Vector3.right, Vector3.down, Vector3.left};
        var origin = transform.position;

        foreach (var direction in _dir) {
            Ray ray = new Ray(origin, direction);

            if (Physics.Raycast(ray, out var hit)) {
                var other = hit.transform.gameObject;
                var otherNeighbor = other.GetComponent<CheckNeighbors>();
                
                if (otherNeighbor != null) {
                    if (otherNeighbor.colorID == colorID) {
                        if (otherNeighbor.groupToDelete.Contains(gameObject)) {
                            groupCount += otherNeighbor.groupCount - 1;
                        }
                        else {
                            groupCount += otherNeighbor.groupCount;   
                        }
                        groupToDelete.Add(other);
                        if (groupCount >= 4) {
                            readyToDelete = true;
                        }
                    }
                }
            }
        }

        if (!readyToDelete) {
            groupToDelete = new List<GameObject> {gameObject};
        }
        groupCount = 1;
    }
}
