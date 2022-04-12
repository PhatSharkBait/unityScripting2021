using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class LocationRotationListSO : ScriptableObject {
    public List<LocationRotationSO> locationRotationTypes;

    public void ClearList(){
        locationRotationTypes.Clear();
    }

    public void AddLocationRotationTypeToList(LocationRotationSO value) {
        locationRotationTypes.Add(value);
    }
}
