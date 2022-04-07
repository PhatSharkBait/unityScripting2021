using UnityEngine;

public class SpawnCollectables : MonoBehaviour {
    [SerializeField] private Vector3ListSO activeTileList;
    [SerializeField] private LocationRotationListSO wallList;
    [SerializeField] private GameObject objsToCollect;
    [SerializeField] private GameObject urinal;
    [SerializeField] private float verticalOffset = 1f;

    public void SpawnObjects() {
        var count = 15;
        while (count > 0) {
            var totalTiles = activeTileList.Vector3s.Count;
            var position = activeTileList.Vector3s[Random.Range(0, totalTiles)];
            Instantiate(objsToCollect, new Vector3(position.x, position.y + verticalOffset, position.z), Quaternion.identity);
            count--;
        }

        count = 30;
        while (count > 0) {
            var totalWalls = wallList.locationRotationTypes.Count;
            var selectedWall = wallList.locationRotationTypes[Random.Range(0, totalWalls)];
            var positionOffset = new Vector3(0, -1.4f, -.5f);
            var rotationOffset = new Vector3(-90, 90, 0);
            var scaleOffset = new Vector3(0, 1, 0);
            var newObject = Instantiate(urinal, selectedWall.location + positionOffset, selectedWall.rotation);
            newObject.transform.Rotate(rotationOffset);
            newObject.transform.localScale += scaleOffset;
            count--;
        }
    }
}
