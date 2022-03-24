using UnityEngine;

public class SpawnCollectables : MonoBehaviour {
    [SerializeField] private Vector3ListSO activeTileList;
    [SerializeField] private GameObject objsToCollect;
    [SerializeField] private float verticalOffset = 1f;

    public void SpawnObjects() {
        var count = 15;
        while (count > 0) {
            var totalTiles = activeTileList.Vector3s.Count;
            var position = activeTileList.Vector3s[Random.Range(0, totalTiles)];
            Instantiate(objsToCollect, new Vector3(position.x, position.y + verticalOffset, position.z), Quaternion.identity);
            count--;
        }
    }
}
