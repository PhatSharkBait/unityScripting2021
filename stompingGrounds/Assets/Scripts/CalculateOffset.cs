using UnityEngine;
using UnityEngine.Events;

public class CalculateOffset : MonoBehaviour {
    public IntData startOffsetInt;
    
    private int _newOffset;
    private const float OffsetMult = .5f;
    
    public Vector3 offsetVector;
    public UnityEvent finishCalculating;
    private void Start() {
        _newOffset = startOffsetInt.value;
        Offset();
        startOffsetInt.value += 2;
        finishCalculating.Invoke();
    }

    private void Offset() {
        offsetVector = _newOffset switch {
            0 => Vector3.right * OffsetMult,
            1 => Vector3.down * OffsetMult,
            2 => Vector3.left * OffsetMult,
            3 => Vector3.up * OffsetMult,
            _ => offsetVector
        };
    }

    public void CycleOffset() {
        _newOffset += 1;
        if (_newOffset > 3) {
            _newOffset = 0;
        }
        Offset();
    }
}
