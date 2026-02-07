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
    private Renderer pointerCubeRenderer;
    private float _distance = 4f;

    void Awake()
    {
        pointerCubeRenderer = GetComponent<Renderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        inContact = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inContact = false;
    }

    void Update()
    {
        _distance += Input.GetAxis("Mouse ScrollWheel");

        if (inContact) pointerCubeRenderer.material.color = Color.softRed;
        else pointerCubeRenderer.material.color = Color.paleGreen;
    }
    void LateUpdate()
    {
        transform.position = Camera.main.transform.position + Camera.main.transform.forward.normalized * _distance;
    }



}
