using UnityEngine;

public class CreatePair : MonoBehaviour {
    public GameObject blob;
    private void Start() {
        Instantiate(blob, gameObject.transform);
        Instantiate(blob, gameObject.transform);
    }
}
