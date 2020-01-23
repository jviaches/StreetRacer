using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Levels
{
    public class Level1 : ILevel
    {
        public int LevelIndex => 1;

        public List<RoadBlock> GroundPathCollection()
        {
            return new List<RoadBlock>()
            {
                 new RoadBlock("Prefabs/Environment/TestRoad", new Vector3(0, 0, 0)),
                 new RoadBlock("Prefabs/Environment/TestRoad", new Vector3(0, 0, 20)),
                 new RoadBlock("Prefabs/Environment/TestRoad", new Vector3(0, 0, 40)),
                 new RoadBlock("Prefabs/Environment/TestRoad", new Vector3(0, 0, 60)),
                 new RoadBlock("Prefabs/Environment/TestRoad", new Vector3(0, 0, 80)),
            };
        }

        public List<Obstacle> ObstaclesPathCollection()
        {
            return new List<Obstacle>()
            {
                new Obstacle("Prefabs/Environment/RoadObstacle", new Vector3(0, 0, 10)),
                new Obstacle("Prefabs/Environment/RoadObstacle", new Vector3(0, 0, 30)),
                new Obstacle("Prefabs/Environment/RoadObstacle", new Vector3(0, 0, 50)),
                new Obstacle("Prefabs/Environment/RoadObstacle", new Vector3(0, 0, 70)),
            };
        }
    }
}
