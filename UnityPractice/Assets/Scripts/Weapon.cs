using UnityEngine;

[CreateAssetMenu]
public class Weapon : ArtBase, IPurchasable{
    public int powerLevel;
    public int ammo;
    public GameObject fxArt;
    private bool _purchased;
    private int _cashValue;

    public bool Purchased {
        get => _purchased;
        set => _purchased = value;
    }

    public int CashValue {
        get => _cashValue;
        set => _cashValue = value;
    }
}