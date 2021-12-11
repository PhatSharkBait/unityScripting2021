using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;
public class PairSpawnerBehaviour : MonoBehaviour {
    public float spawnDelay;
    public GameObject pairToSpawn;
    public GameAction spawningPair;

    private readonly Vector3 _spawnLocation = new Vector3(4f, 15.5f, 0f);
    private SingleBlobGravity[] puGravityList;
    private CheckNeighbors[] puGroupList;
    private bool _waiting = false;

    private void Start() {
        StartSpawnCoroutine();
    }

    public void FindInitialPu() {
        StartCoroutine(FindAllPu());
    }

    private void StartSpawnCoroutine() {
        if (_waiting) return;
        _waiting = true;
        StartCoroutine(SpawnPair());
    }
    private IEnumerator SpawnPair() {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(pairToSpawn, _spawnLocation, Quaternion.identity);
        _waiting = false;
        StartCoroutine(FindAllPu());
    }

    private IEnumerator FindAllPu() {
        yield return new WaitForSeconds(0f);
        puGravityList = FindObjectsOfType<SingleBlobGravity>();
        puGroupList = FindObjectsOfType<CheckNeighbors>();
    }

    private bool CheckForFrozen() {
        return puGravityList.All(puGravity => !puGravity.canMove);
    }

    private bool CheckForGroups() {
        var didDestroyGroup = false;
        
        foreach (var puGroup in puGroupList) {
            if (puGroup.readyToDelete) {
                didDestroyGroup = true;
                foreach (var pu in puGroup.groupToDelete) {
                    Destroy(pu);
                }
            }
        }

        StartCoroutine(FindAllPu());
        return didDestroyGroup;
    }

    public void TrySpawn() {
        if (CheckForGroups()) {
            UpdateAfterDelete();
            return;
        }
        if (!CheckForFrozen()) return;
        StartSpawnCoroutine();
    }

    public void UpdateAfterDelete() {
        StartCoroutine(FindAllPu());
        foreach (var puGravity in puGravityList) {
            puGravity.canMove = true;
        }
    }
}
