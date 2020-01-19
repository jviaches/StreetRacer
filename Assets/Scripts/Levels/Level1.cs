using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Levels
{
    public class Level1 : ILevel
    {
        public int LevelIndex => 1;

        public List<string> GroundPathCollection()
        {
            return new List<string>()
            {
                "Prefabs/Environment/TestRoad",
                "Prefabs/Environment/TestRoad",
                "Prefabs/Environment/TestRoad",
                "Prefabs/Environment/TestRoad",
                "Prefabs/Environment/TestRoad",
            };
        }
    }
}
