using UnityEngine;

public class Player1_Camera : MonoBehaviour
{
    // Attributes

    // public
    [Header("Camera Settings")]
    public Vector2 cameraSensibility = new Vector2(20f, 23f);

    // private
    private float _cameraRotationX;
    private float _cameraRotationY;
    private float _minRotation = -80;
    private float _maxRotation = 80;
    private Transform _cameraTransform;


    void Start()
    {
        _cameraTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        _cameraRotationX += Input.GetAxis("Mouse X") * cameraSensibility.x * Time.deltaTime;
        _cameraRotationY += Input.GetAxis("Mouse Y") * cameraSensibility.y * Time.deltaTime;

        _cameraRotationY = Mathf.Clamp(_cameraRotationY, _minRotation, _maxRotation);

        _cameraTransform.localRotation = Quaternion.Euler(-_cameraRotationY, 0f, 0f);
        transform.rotation = Quaternion.Euler(0f, _cameraRotationX, 0f);
    }
}
