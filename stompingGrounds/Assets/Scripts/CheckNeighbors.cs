using System.Collections.Generic;
using UnityEngine;

public class CheckNeighbors : MonoBehaviour {
    private Vector3[] _dir;
    private ListData _allPuData;

    public int groupCount;
    public bool readyToDelete = false;
    public List<GameObject> groupToDelete;
    public int colorID;

    private void Start() {
        _allPuData = FindObjectOfType<ListData>();
        groupToDelete = new List<GameObject> {gameObject};
        colorID = gameObject.GetComponent<SetBlobColor>().colorID;
        groupCount = 1;
    }

    public void CheckInDirection() {
        _dir = new []{Vector3.up, Vector3.right, Vector3.down, Vector3.left};
        var origin = transform.position;

        foreach (var other in _allPuData.gameObjectList) {
            var otherNeighbor = other.GetComponent<CheckNeighbors>();
            
            if (otherNeighbor.colorID == colorID) {
                var distanceTo = Mathf.Abs(Vector3.Distance(other.transform.position, this.transform.position));
                
                if (distanceTo <= 1.4f) {
                    var listToRead = otherNeighbor.groupToDelete;
                    foreach (var pu in listToRead) {
                        if (!groupToDelete.Contains(pu)) {
                            groupToDelete.Add(pu);
                        }
                    }
                }
            }
        }

        if (groupToDelete.Count >= 4) {
            readyToDelete = true;
        }
    }
}
