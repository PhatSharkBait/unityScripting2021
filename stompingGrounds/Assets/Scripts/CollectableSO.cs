using UnityEngine;

public class CollectableSO : ScriptableObject {
    public bool collected = false;
    public int costValue;
    public GameObject art;
    public Sprite art2D;
    public Color artColorTint = Color.blue;
}
