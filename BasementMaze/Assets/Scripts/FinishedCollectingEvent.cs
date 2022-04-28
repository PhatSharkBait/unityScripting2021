using UnityEngine.Events;
using UnityEngine;

public class FinishedCollectingEvent : MonoBehaviour {
    public UnityEvent finishedCollecting;
    public IntDataSO remainingCollectables;

    private bool CheckRemainingCollectables() {
        return remainingCollectables.value <= 0;
    }

    public void CheckFinishedCollecting() {
        if (CheckRemainingCollectables()) {
            finishedCollecting.Invoke();
        }
    }
}
