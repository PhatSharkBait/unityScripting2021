using System.Collections;
using UnityEngine;
public class PairSpawnerBehaviour : MonoBehaviour {
    public float spawnDelay;
    public GameObject pairToSpawn;
    public GameAction spawningPair;

    private readonly Vector3 _spawnLocation = new Vector3(4f, 15.5f, 0f);

    public void StartSpawnCoroutine() {
        print("waiting");
        StartCoroutine(SpawnPair());
    }
    private IEnumerator SpawnPair() {
        yield return new WaitForSeconds(spawnDelay);
        print("spawning");
        spawningPair.Raise();
        Instantiate(pairToSpawn, _spawnLocation, Quaternion.identity);
    }
}
