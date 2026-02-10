using UnityEngine;
using System.Collections.Generic;
using System.IO;

public static class Data_Controller
{
    // Attributes
    // public

    // private
    private static List<Vector3> cubePositions = new List<Vector3>();
    private static string filePath = Application.dataPath + "/Data/cubes.json";

    // Methods
    public static void SaveData(Vector3 position)
    {
        cubePositions.Add(position);
    }

    [System.Serializable]
    private class CubePositionBucket
    {
        public List<Vector3> positions;
    }

    public static void SaveToJson()
    {
        CubePositionBucket wrapper = new CubePositionBucket();
        wrapper.positions = cubePositions;

        string jsonString = JsonUtility.ToJson(wrapper);
        File.WriteAllText(filePath, jsonString);
    }

    public static List<Vector3> LoadFromJson()
    {
        if (!File.Exists(filePath))
            return new List<Vector3>();

        string jsonString = File.ReadAllText(filePath);
        CubePositionBucket wrapper = JsonUtility.FromJson<CubePositionBucket>(jsonString);

        return wrapper.positions;
    }

    public static void ResetData()
    {
        cubePositions.Clear();
    }

}