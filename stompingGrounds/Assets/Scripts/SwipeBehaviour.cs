using System.Collections;
using UnityEngine;

//Created from tutorial
//https://www.youtube.com/watch?v=rDK_3qXHAFg

public class SwipeBehaviour : MonoBehaviour {
    public BoolData doubleTap, swipeLeft, swipeRight, swipeUp, swipeDown;
    public Vector2 startTouch, swipeDelta;

    private bool _isDragging;
    private bool _singleTap;
    private void Update() {
        doubleTap.value = swipeLeft.value = swipeRight.value = swipeUp.value = swipeDown.value = false;

        //PC Inputs
        if (Input.GetMouseButtonDown(0) && !_singleTap) {
            print("tap");
            _singleTap = true;
            _isDragging = true;
            startTouch = Input.mousePosition;
            StartCoroutine(CheckForDoubleTap());
        } else if (Input.GetMouseButtonDown(0) && _singleTap) {
            print("DoubleTapped");
            doubleTap.value = true;
            _singleTap = false;
        }
        else if (Input.GetMouseButtonDown(0)) {
            Reset();
        }
        
        
        /*//Mobile Inputs
        if (Input.touches.Length != 0) {
            if (Input.touches[0].phase == TouchPhase.Began && !_singleTap) {
                _isDragging = true;
                _singleTap = true;
                startTouch = Input.touches[0].position;
            } else if (Input.touches[0].phase == TouchPhase.Began && _singleTap) {
                doubleTap.value = true;
                _singleTap = false;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled) {
                Reset();
            }
        }*/
        
        //Calculate Swipe Distance
        swipeDelta = Vector2.zero;
        if (_isDragging) {
            if (Input.touches.Length > 0) {
                swipeDelta = Input.touches[0].position - startTouch;
                
            } else if (Input.GetMouseButton(0)) {
                swipeDelta = (Vector2) Input.mousePosition - startTouch;
            }
        }

        if (swipeDelta.magnitude > 125) {
            _singleTap = false;
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y)) {
                if (x < 0) {
                    swipeLeft.value = true;
                }
                else {
                    swipeRight.value = true;
                }
            }
            else {
                if (y < 0) {
                    swipeDown.value = true;
                }
                else {
                    swipeUp.value = true;
                }
            }
            Reset();
        }
    }

    private void Reset() {
        startTouch = swipeDelta = Vector2.zero;
        _isDragging = false;
        doubleTap.value = false;
    }

    private IEnumerator CheckForDoubleTap() {
        yield return new WaitForSeconds(.75f);
        _singleTap = false;
    }
}
