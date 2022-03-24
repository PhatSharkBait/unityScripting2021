using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3ListSO : ScriptableObject {
    public List<Vector3> Vector3s;

    public void ClearList(){
        Vector3s.Clear();
    }

    public void AddVector3ToList(Vector3 newVector3) {
        Vector3s.Add(newVector3);
    }
}
