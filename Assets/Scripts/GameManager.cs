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

    private ILevel currentLevel;
    private ICar playerCar;
    private bool isPlayingLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = GameSettings.GetCurrentLevel();
        playerCar = GameSettings.SelectedCar;
        isPlayingLevel = true;
        initEnvironment();
        initPlayer();
        initObsticles();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayingLevel)
        {
            generateGround();
            generateObsticles();
        }
    }

    private void initObsticles()
    {
        for (int i = 0; i < currentLevel.ObstaclesPathCollection().Count; i++)
        {
            Obstacle obstacleItem = currentLevel.ObstaclesPathCollection()[i];

            GameObject obstacle = Instantiate((GameObject)Resources.Load(obstacleItem.Prefab));
            obstacle.transform.position = obstacleItem.Location;
        }
    }

    private void generateObsticles()
    {
        // Update obstacles objects
        Obstacle[] obstacles = (Obstacle[])FindObjectsOfType(typeof(Obstacle));
        foreach (var obstacle in obstacles)
        {
            if (playerObject.transform.position.z - obstacle.transform.position.z > 10)
                Destroy(obstacle.gameObject);
            else
                (obstacle as Obstacle).transform.Translate(Vector3.back * GameSettings.MovingSpeed * Time.deltaTime);
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
        playerObject = Instantiate((GameObject)Resources.Load("Prefabs/Player/PlayerCar"));
        playerObject.transform.position = new Vector3();
    }
}
