using UnityEngine;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(Rigidbody))]

public class PointerCube_Triggers : MonoBehaviour
{

    // Attributes
    // public
    [System.NonSerialized]
    public bool inContact;

    // private
    private Renderer _pointerCubeRenderer;
    private float _distance = 4f;
    private float _floorMin;

    // Methods
    void Awake()
    {
        _pointerCubeRenderer = GetComponent<Renderer>();
        _floorMin = transform.localScale.y / 2;
    }
    private void OnTriggerEnter(Collider other)
    {
        inContact = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inContact = false;
    }

    void LateUpdate()
    {
        if (inContact) _pointerCubeRenderer.material.color = Color.softRed;
        else _pointerCubeRenderer.material.color = Color.paleGreen;

        _distance += Input.GetAxis("Mouse ScrollWheel");
        _distance = Mathf.Clamp(_distance, 2, 10);

        Vector3 cubePosition = Camera.main.transform.position + Camera.main.transform.forward.normalized * _distance;
        if (cubePosition.y < _floorMin)
            cubePosition.y = _floorMin;

        transform.position = cubePosition;
    }



}
