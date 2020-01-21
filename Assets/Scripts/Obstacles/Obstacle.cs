using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Vector3 _location;

    public Obstacle(string prefabPath, Vector3 location)
    {
        Prefab = prefabPath;
        Location = location;
    }

    public string Prefab { get; set; }
    public Vector3 Location { get; set; }
}
