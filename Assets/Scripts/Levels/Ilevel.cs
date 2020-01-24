using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Levels
{
    public interface ILevel
    {
        int LevelIndex { get; }
        float LevelTimerLimit { get; }
        List<RoadBlock> GroundPathCollection();
        List<StaticObstacle> ObstaclesPathCollection();
        List<MovingObstacle> MovingObstaclesPathCollection(); 
    }
}
