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

        public float LevelTimerLimit => 45f; // 45 sec

        public List<RoadBlock> GroundPathCollection()
        {
            return new List<RoadBlock>()
            {
                 // road
                 new RoadBlock("Prefabs/Environment/Straight_1C", new Vector3(0, 0, 0)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 20)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 40)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 60)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 80)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 100)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 120)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 140)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 160)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 180)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 200)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 220)),
                 new RoadBlock("Prefabs/Environment/RaceTrackLong", new Vector3(0, 0, 240)),

                 // sides pavement
                 new RoadBlock("Prefabs/Environment/Pavement_1A_long Variant", new Vector3(7, -0.3f, 124)),

                 // right side
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 5)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 20)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 35)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 50)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 65)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 80)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 95)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 110)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 125)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 140)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 155)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 170)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 185)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 200)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 215)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 230)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(8, 0, 245)),


                 // left side
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 5)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 20)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 35)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 50)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 65)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 80)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 95)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 110)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 125)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 140)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 155)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 170)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 185)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 200)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 215)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 230)),
                 new RoadBlock("Prefabs/Environment/Side_Impact_Fence_1", new Vector3(-5, 0, 245)),

                 //tribunes
                 new RoadBlock("Prefabs/Environment/Stand_1E", new Vector3(-15, -0.15f, 45)),
                 new RoadBlock("Prefabs/Environment/Stand_1E", new Vector3(-15, -0.15f, 55.21f)),
                 new RoadBlock("Prefabs/Environment/Stand_1E", new Vector3(-15, -0.15f, 65.2f)),
            };
        }

        public List<StaticObstacle> ObstaclesPathCollection()
        {
            return new List<StaticObstacle>()
            {
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(1.4f, 0, 10)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0.25f, 0, 10)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(2.73f, 0, 10)),

                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(-1.2f, 0, 30)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(-2.6f, 0, 30)),

                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(2.73f, 0, 50)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0.25f, 0, 52)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(1.4f, 0, 54)),

                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0, 0, 65)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0, 0, 68)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0, 0, 70)),

                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(-2.6f, 0, 88)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(-1.2f, 0, 90)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0, 0, 93)),

                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0, 0, 110)),

                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(1.4f, 0, 130)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(0.25f, 0, 130)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(2.73f, 0, 130)),

                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(-1.2f, 0, 140)),
                new StaticObstacle("Prefabs/Environment/Cone_1A", new Vector3(-2.6f, 0, 140)),              
                //new StaticObstacle("Prefabs/Environment/Impact_Tires_2C", new Vector3(0, 0, 50)),
            };
        }

        public List<MovingObstacle> MovingObstaclesPathCollection()
        {
            return new List<MovingObstacle>()
            {
                new MovingObstacle("Prefabs/Environment/MovingObstacle", new Vector3(0, 0, 15)) { Speed = 3 },
                new MovingObstacle("Prefabs/Environment/MovingObstacle", new Vector3(0, 0, 25)) { Speed = 5 },
            };
        }
    }
}
