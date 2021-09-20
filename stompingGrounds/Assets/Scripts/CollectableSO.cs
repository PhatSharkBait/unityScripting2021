using System.Collections.Generic;
using UnityEngine;

public class CollectableSO : ScriptableObject {
    public bool collected = false;
    public int costValue;
    public GameObject art;
    public Color artColorTint = Color.blue;
}
