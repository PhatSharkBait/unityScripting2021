public class BasicInteractable : InteractableBase {
    protected override void OnRangeEnter() {
        base.OnRangeEnter();
        print("in range");
    }

    protected override void OnRangeExit() {
        base.OnRangeExit();
        print("left range");
    }

    protected override void OnInteract() {
        print("picky uppy");
    }
}
