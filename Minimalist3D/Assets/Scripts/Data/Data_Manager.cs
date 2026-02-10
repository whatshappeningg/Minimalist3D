using UnityEngine;
using System.Collections.Generic;

public class Data_Manager : MonoBehaviour
{
    // Attributes
    // public
    [Header("Prefab to instantiate")]
    public GameObject cubePrefab;

    // private
    private List<Vector3> _cubePositions = new List<Vector3>();

    // Methods
    void Awake()
    {
        Data_Controller.ResetData();

        _cubePositions = Data_Controller.LoadFromJson();

        foreach (Vector3 position in _cubePositions)
        {
            Instantiate(cubePrefab, position, Quaternion.identity);
        }

    }

    void OnDestroy()
    {
        Data_Controller.SaveToJson();
    }
}
