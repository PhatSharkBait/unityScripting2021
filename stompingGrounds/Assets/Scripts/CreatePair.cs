using UnityEngine;

public class CreatePair : MonoBehaviour {
    public GameObject blob;
    public IntData offset;
    private void Start() {
        offset.value = 1;
        Instantiate(blob, gameObject.transform);
        Instantiate(blob, gameObject.transform);
    }
}
