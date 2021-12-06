using UnityEngine;

public class CheckNeighbors : MonoBehaviour
{
    public bool CheckInDirection() {
        var dir = Vector3.up;
        var origin = transform.position;

        Ray ray = new Ray(origin, dir);

        if (Physics.Raycast(ray, out var hit)) {
            Debug.Log(hit);
        }
        else {
            return false;
        }
        
        return hit.collider.gameObject;
    }
}
