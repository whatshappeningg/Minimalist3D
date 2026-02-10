using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PointerCube_Triggers))]

public class Cube_Instantiator : MonoBehaviour
{
    // Attributes
    // public
    [Header("Prefab to instantiate")]
    public GameObject cubePrefab;

    // private
    private PointerCube_Triggers _triggersScript;

    // Methods
    void Awake()
    {
        _triggersScript = GetComponent<PointerCube_Triggers>();
    }
    void Update()
    {
        if (Input.GetButtonUp("Fire1") && !_triggersScript.inContact)
            StartCoroutine(CubeInstantiator());
    }

    IEnumerator CubeInstantiator()
    {
        yield return new WaitForEndOfFrame();

        Instantiate(cubePrefab, transform.position, transform.rotation);
    }
}
