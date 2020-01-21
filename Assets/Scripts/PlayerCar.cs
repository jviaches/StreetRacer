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
        private Gyroscope gyro;

        private float leftRoadBodundary = -4.5f;
        private float rigtRoadBodundary = 4.5f;
        private float sideSpeed = 0.05f;

        public float Speed { get; set; }

        void Awake()
        {
            currentLevel = GameSettings.GetCurrentLevel();
        }

        protected void OnGUI()
        {
            GUI.skin.label.fontSize = Screen.width / 40;

            GUILayout.Label("Orientation: " + Screen.orientation);
            GUILayout.Label("input.gyro.attitude x: " + Input.gyro.attitude.x);
            //GUILayout.Label("input.gyro.attitude y: " + Input.gyro.attitude.y);
            //GUILayout.Label("input.gyro.attitude z: " + Input.gyro.attitude.z);
            //GUILayout.Label("input.gyro.attitude w: " + Input.gyro.attitude.w);
        }

        void Start()
        {
            Speed = 5f;

            mainCamera = Camera.main;
            mainCameraOffset = mainCamera.transform.position - transform.position;

            gyro = Input.gyro;
            gyro.enabled = true;
        }

        private void Update()
        {
            if (Input.GetKey("left") && transform.position.x > leftRoadBodundary)
                transform.position = new Vector3(transform.position.x - sideSpeed, 0, 0);


            if (Input.GetKey("right") && transform.position.x < rigtRoadBodundary)
                transform.position = new Vector3(transform.position.x + sideSpeed, 0, 0);

           
            GyroModifyCamera();
        }

        // The Gyroscope is right-handed.  Unity is left handed.
        // Make the necessary change to the camera.
        void GyroModifyCamera()
        {
            if (SystemInfo.supportsGyroscope)
            {
                // tilt right
                if (Input.gyro.attitude.x < -0.05 && transform.position.x < rigtRoadBodundary)
                    transform.position = new Vector3(transform.position.x + sideSpeed, 0, 0);

                // tilt left
                if (Input.gyro.attitude.x > 0.05 && transform.position.x > leftRoadBodundary)
                    transform.position = new Vector3(transform.position.x - sideSpeed, 0, 0);
            }
        }
    }
}
