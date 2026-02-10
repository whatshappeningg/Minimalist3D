using UnityEngine;
using System.Collections.Generic;

public class Data_Manager : MonoBehaviour
{
    // Attributes
    // public
    [Header("Prefab to instantiate")]
    public GameObject cubePrefab;

    // private
    private List<Vector3> cubePositions = new List<Vector3>();

    // Methods
    void Awake()
    {
        Data_Controller.ResetData();

        cubePositions = Data_Controller.LoadFromJson();

        foreach (Vector3 position in cubePositions)
        {
            Instantiate(cubePrefab, position, Quaternion.identity);
        }

    }

    void OnDestroy()
    {
        Data_Controller.SaveToJson();
    }

}
