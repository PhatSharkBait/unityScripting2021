using System;
using UnityEngine;

public class InteractableDoor : InteractableBase {
    private void Awake() {
        interactionText = "Click to Open";
    }

    protected override void OnRangeEnter() {
        base.OnRangeEnter();
    }

    protected override void OnRangeExit() {
        base.OnRangeExit();
    }

    protected override void OnInteract() {
        RaiseDoor();
        interactionText = "Opening...";
    }

    private void RaiseDoor() {
        gameObject.transform.Translate(Vector3.up * 3f);
    }
}
