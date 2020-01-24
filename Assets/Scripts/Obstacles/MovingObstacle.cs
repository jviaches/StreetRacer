using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : Obstacle
{
    public float Speed { get; set; }

    public MovingObstacle(string prefabPath, Vector3 location): base(prefabPath, location)
    {
        Debug.Log(Speed);
    }
}
