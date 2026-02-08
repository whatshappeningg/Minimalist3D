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
    private Renderer _cubeRenderer;
    private PointerCube_Triggers _triggersScript;
    private Color[] _arrayColors = { Color.sandyBrown, Color.black, Color.skyBlue, Color.blueViolet, Color.yellowGreen };

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

        GameObject cube = Instantiate(cubePrefab, transform.position, transform.rotation);

        _cubeRenderer = cube.GetComponent<Renderer>();
        _cubeRenderer.material.color = _arrayColors[Random.Range(0, _arrayColors.Length)];

    }
}
