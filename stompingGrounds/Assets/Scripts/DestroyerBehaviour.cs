using System.Collections;
using UnityEngine;

public class DestroyerBehaviour : MonoBehaviour {
    public float holdTime = 2f;
    private IEnumerator Start() {
        yield return new WaitForSeconds(holdTime);
        Destroy(gameObject);
    }
}
