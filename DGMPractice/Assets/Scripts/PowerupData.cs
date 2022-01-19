using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class PowerupData : MonoBehaviour, IPowerUp {
    protected int powerID;

    private void Start() {
        collider = GetComponent<BoxCollider>();
        PrintName();
        ApplyToPlayer();
        OnSpawn();
    }

    protected virtual void PrintName() {
        print("Null powerup");
    }

    protected virtual void ApplyToPlayer() {
        print("get player");
    }

    public new BoxCollider collider { get; set; }
    public float PowerupID { get; set; }

    public void OnPickup() {
        throw new System.NotImplementedException();
    }

    public void OnSpawn() {
        collider.center = new Vector3(0, 0, 0);
        collider.size = new Vector3(1, 1, 1);
    }
}

public interface IPowerUp {
    BoxCollider collider { get; set; }
    public float PowerupID { get; set; }
    void OnPickup();
    void OnSpawn();
}
