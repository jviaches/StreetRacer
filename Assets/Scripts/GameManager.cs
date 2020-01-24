using Assets.Scripts;
using Assets.Scripts.Cars;
using Assets.Scripts.Levels;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject playerObject;
    private Camera mainCamera;
    private ILevel currentLevel;
    private ICar playerCar;
    private bool isPlayingLevel;
    private float levelTimer;

    protected void OnGUI()
    {
        GUI.skin.label.fontSize = Screen.width / 40;

        GUILayout.Label("Timer: " + levelTimer);
    }

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        currentLevel = GameSettings.GetCurrentLevel();
        playerCar = GameSettings.SelectedCar;
        
        initEnvironment();
        initPlayer();
        initStaticObsticles();
        initMovingObsticles();

        isPlayingLevel = true;
        levelTimer = currentLevel.LevelTimerLimit;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayingLevel)
        {
            levelTimer -= Time.deltaTime;
            generateGround();
            generateStaticObsticles();
            generateMovingObsticles();
        }
    }

    private void initStaticObsticles()
    {
        for (int i = 0; i < currentLevel.ObstaclesPathCollection().Count; i++)
        {
            StaticObstacle obstacleItem = currentLevel.ObstaclesPathCollection()[i];

            GameObject obstacle = Instantiate((GameObject)Resources.Load(obstacleItem.Prefab));
            obstacle.transform.position = obstacleItem.Location;
        }
    }

    private void initMovingObsticles()
    {
        for (int i = 0; i < currentLevel.MovingObstaclesPathCollection().Count; i++)
        {
            MovingObstacle obstacleItem = currentLevel.MovingObstaclesPathCollection()[i];
            Debug.LogWarning(obstacleItem.Speed+ " asd");

            GameObject obstacle = Instantiate((GameObject)Resources.Load(obstacleItem.Prefab));
            obstacle.transform.position = obstacleItem.Location;
        }
    }

    private void generateStaticObsticles()
    {
        StaticObstacle[] obstacles = (StaticObstacle[])FindObjectsOfType(typeof(StaticObstacle));
        foreach (var obstacle in obstacles)
        {
            if (playerObject.transform.position.z - obstacle.transform.position.z > 10)
                Destroy(obstacle.gameObject);
            else
                (obstacle as StaticObstacle).transform.Translate(Vector3.back * GameSettings.MovingSpeed * Time.deltaTime);
        }
    }

    private void generateMovingObsticles()
    {
        MovingObstacle[] obstacles = (MovingObstacle[])FindObjectsOfType(typeof(MovingObstacle));
        foreach (var obstacle in obstacles)
        {            
            if (playerObject.transform.position.z - obstacle.transform.position.z > 10)
                Destroy(obstacle.gameObject);
            else
                (obstacle as MovingObstacle).transform.Translate(Vector3.back * (GameSettings.MovingSpeed - obstacle.Speed) * Time.deltaTime);
        }
    }

    private void generateGround()
    {
        RoadBlock[] roadBlocks = (RoadBlock[])FindObjectsOfType(typeof(RoadBlock));
        foreach (var roadBlock in roadBlocks)
        {
            if (playerObject.transform.position.z - roadBlock.transform.position.z > 30)
                Destroy(roadBlock.gameObject);
            else
                (roadBlock as RoadBlock).transform.Translate(Vector3.back * GameSettings.MovingSpeed * Time.deltaTime);
        }
    }

    private void initEnvironment()
    {
        for (int i = 0; i < currentLevel.GroundPathCollection().Count; i++)
        {
            RoadBlock roadBlockItem = currentLevel.GroundPathCollection()[i];

            GameObject obstacle = Instantiate((GameObject)Resources.Load(roadBlockItem.Prefab));
            obstacle.transform.position = roadBlockItem.Location;
        }
    }

    private void initPlayer()
    {
        playerObject = Instantiate((GameObject)Resources.Load("Prefabs/Cars/Car1"));
        mainCamera.transform.SetParent(playerObject.transform);
        playerObject.transform.position = new Vector3(-2.11f,0,0);
    }
}
