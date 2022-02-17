using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Store : ScriptableObject {
    public List<ScriptableObject> purchaseList;
    private List<IPurchasable> _purchasables;

    private void OnEnable() {
        _purchasables = new List<IPurchasable>();
        foreach (var obj in purchaseList) {
            _purchasables.Add(obj as IPurchasable);
        }
    }
}
