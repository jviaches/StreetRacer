using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : MonoBehaviour
{
    public GameItem(string prefabPath, Vector3 location)
    {
        Prefab = prefabPath;
        Location = location;
    }

    public string Prefab { get; set; }
    public Vector3 Location { get; set; }
}
