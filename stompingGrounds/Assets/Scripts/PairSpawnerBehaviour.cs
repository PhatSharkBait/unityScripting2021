using System.Collections;
using UnityEngine;
public class PairSpawnerBehaviour : MonoBehaviour {
    public bool blob1;
    public float spawnDelay;
    public GameObject pairToSpawn;
    public GameAction spawningPair;

    private readonly Vector3 _spawnLocation = new Vector3(4f, 15.5f, 0f);

    private void Start() {
        blob1 = false;
    }

    public void SetNextBlob() {
        if (!blob1) {
            blob1 = true;
        }
        else {
            blob1 = false;
            StartCoroutine(SpawnPair());
        }
    }

    private IEnumerator SpawnPair() {
        yield return new WaitForSeconds(spawnDelay);
        spawningPair.Raise();
        Instantiate(pairToSpawn, _spawnLocation, Quaternion.identity);
    }
    
}
