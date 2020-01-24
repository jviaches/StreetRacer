using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObstacle : Obstacle
{
    public StaticObstacle(string prefabPath, Vector3 location) : base(prefabPath, location)
    {
    }
}
