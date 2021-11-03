using System;
using System.Collections;
using System.Linq;
using UnityEngine;
public class PairSpawnerBehaviour : MonoBehaviour {
    public float spawnDelay;
    public GameObject pairToSpawn;
    public GameAction spawningPair;

    private readonly Vector3 _spawnLocation = new Vector3(4f, 15.5f, 0f);
    private SingleBlobGravity[] puGravityList;

    public void FindInitialPu() {
        StartCoroutine(FindAllPu());
    }

    private void StartSpawnCoroutine() {
        print("waiting");
        StartCoroutine(SpawnPair());
    }
    private IEnumerator SpawnPair() {
        yield return new WaitForSeconds(spawnDelay);
        print("spawning");
        Instantiate(pairToSpawn, _spawnLocation, Quaternion.identity);
        StartCoroutine(FindAllPu());
    }

    private IEnumerator FindAllPu() {
        yield return new WaitForSeconds(.25f);
        puGravityList = FindObjectsOfType<SingleBlobGravity>();
    }

    private bool CheckForFrozen() {
        return puGravityList.All(puGravity => !puGravity.canMove);
    }

    public void TrySpawn() {
        if (CheckForFrozen()) {
            StartSpawnCoroutine();
        }
    }
}
