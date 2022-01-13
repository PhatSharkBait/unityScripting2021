using UnityEngine;

public class PowerupData : MonoBehaviour {
    protected int powerID;

    private void Start() {
        PrintName();
        ApplyToPlayer();
    }

    protected virtual void PrintName() {
        print("Null powerup");
    }

    protected virtual void ApplyToPlayer() {
        print("get player");
    }
}
