using Assets.Scripts.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public static class GameSettings
    {
        // 1rs param level, 2nd param amount of stars, 3rd param score
        public static Dictionary<ILevel, KeyValuePair<int, int>> Episode1Levels = new Dictionary<ILevel, KeyValuePair<int, int>>();

        public static int SelectedLevelIndex = 0;                   // Level chosen by user
        public static readonly float ValueIsNotSet = -1;
        public static float MovingSpeed = 5f;
        public static readonly float PlayVisibilityZcoordStart = 130; // Z axis from where player able to see the object

        static GameSettings()
        {
            if (Episode1Levels.Count > 0)
                return;

            InitEpisode1();
        }

        private static void InitEpisode1()
        {
            Episode1Levels.Add(new Level1(), new KeyValuePair<int, int>(0, 0));
            //Episode1Levels.Add(new Level_FloatingIslands(), new KeyValuePair<int, int>(0, 0));
            //Episode1Levels.Add(new Level_Lake(), new KeyValuePair<int, int>(0, 0));
        }

        public static ILevel GetCurrentLevel()
        {
            int lvlIndex = SelectedLevelIndex == 0 ? 1 : SelectedLevelIndex;    // can be 0 in case if no games were played before
            return Episode1Levels.Keys.First(lvl => lvl.LevelIndex == lvlIndex);
        }
    }
}
