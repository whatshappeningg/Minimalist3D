using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Cube_Initializer : MonoBehaviour
{
    // Attributes
    // public

    // private
    private Renderer _cubeRenderer;
    private Color[] _arrayColors = { Color.sandyBrown, Color.black, Color.skyBlue, Color.blueViolet, Color.yellowGreen };

    // Methods
    void Awake()
    {
        Data_Controller.SaveData(transform.position);

        _cubeRenderer = GetComponent<Renderer>();
        _cubeRenderer.material.color = _arrayColors[Random.Range(0, _arrayColors.Length)];
    }
}