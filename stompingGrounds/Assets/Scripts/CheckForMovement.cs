using System.Linq;
using UnityEngine;

public class CheckForMovement : MonoBehaviour {
    public GridManager gridManager;
    
    public void CheckAllPu() {
        var activePu = FindObjectsOfType<SingleBlobGravity>();
        if (activePu.All(gravity => !gravity.canMove)) {
            gridManager.HandleLandedPu();
        }
    }
}
