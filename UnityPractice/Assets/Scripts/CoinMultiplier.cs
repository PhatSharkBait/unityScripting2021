using UnityEngine;

[CreateAssetMenu]
public class CoinMultiplier : ScriptableObject, IPurchasable {
    public IntData coins;

    public void MultiplyCoin(int num) {
        coins.value *= num;
    }

    public bool Purchased { get; set; }
    public int CashValue { get; set; }
}
