using Assets.Scripts.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerCar : MonoBehaviour // former PlayerScript
    {
        private Camera mainCamera;
        private Vector3 mainCameraOffset;

        private ILevel currentLevel;
        public float Speed { get; set; }

        void Awake()
        {
            currentLevel = GameSettings.GetCurrentLevel();
        }

        void Start()
        {
            Speed = 5f;

            mainCamera = Camera.main;
            mainCameraOffset = mainCamera.transform.position - transform.position;
        }
    }
}
