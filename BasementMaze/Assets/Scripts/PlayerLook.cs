using UnityEngine;

public class PlayerLook : MonoBehaviour {
    public float sensitivity;
    public Transform playerBody;
    public Joystick lookJoystick;

    private float xRotation = 0f;

    // private void Start() {
    //     Cursor.lockState = CursorLockMode.Confined;
    // }

    void Update() {
        float horizontal = lookJoystick.Horizontal * sensitivity * Time.deltaTime;
        float vertical = lookJoystick.Vertical * sensitivity * Time.deltaTime;
        
        xRotation -= vertical;
        xRotation =  Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * horizontal);
    }
}
