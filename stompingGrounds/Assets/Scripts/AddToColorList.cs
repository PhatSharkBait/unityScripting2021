using UnityEngine;

public class AddToColorList : MonoBehaviour {
    private ListData _allPuList;
    private void Start() {
        _allPuList = FindObjectOfType<ListData>();
        _allPuList.AddObjectToList(gameObject);
    }

    private void OnDestroy() {
        _allPuList.RemoveObjectFromList(gameObject);
    }
}
