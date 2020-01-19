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
        List<string> GroundPathCollection(); // prev: GetFloorPathCollection
    }
}
