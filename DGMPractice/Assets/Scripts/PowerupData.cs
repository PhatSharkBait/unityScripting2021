using UnityEngine;

public class PowerupData : MonoBehaviour {
    public int powerID;

    private void Start() {
        PrintName();
    }

    protected virtual void PrintName() {
        print("Null powerup");
    }
}
