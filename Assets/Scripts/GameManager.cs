using Assets.Scripts;
using Assets.Scripts.Levels;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject playerObject;

    private ILevel currentLevel;
    private bool isPlayingLevel;
    private List<GameObject> groundObjectsPool;     // prev: floorPool

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = GameSettings.GetCurrentLevel();
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
        // Update floatable objects
        Obstacle[] floatables = (Obstacle[])FindObjectsOfType(typeof(Obstacle));
        foreach (var coin in floatables)
        {
            if (playerObject.transform.position.z - coin.transform.position.z > 10)
                Destroy(coin.gameObject);
            else
                (coin as Obstacle).transform.Translate(Vector3.back * GameSettings.MovingSpeed * Time.deltaTime);
        }
    }


    private void generateGround()
    {
        for (int i = 0; i < groundObjectsPool.ToArray().Length; i++)
        {
            GameObject tileGameObject = groundObjectsPool[i];
            tileGameObject.transform.Translate(Vector3.back * GameSettings.MovingSpeed * Time.deltaTime);

            RaycastHit hit;
            if (Physics.Raycast(tileGameObject.transform.position, Vector3.back, out hit, 0.5f) && hit.transform.gameObject.tag == "ObjectErasePoint")
            {
                groundObjectsPool.Remove(tileGameObject);
                Destroy(tileGameObject);

                //int result = UnityEngine.Random.Range(0, currentLevel.GroundPathCollection().Count - 1);

                Vector3 newPosition = groundObjectsPool[groundObjectsPool.Count - 1].transform.position + new Vector3(0, 0, groundObjectsPool[groundObjectsPool.Count - 1].GetComponent<Renderer>().bounds.size.z);
                tileGameObject = Instantiate((GameObject)Resources.Load(currentLevel.GroundPathCollection()[i]), newPosition, Quaternion.LookRotation(Vector3.forward));

                tileGameObject.transform.localScale += new Vector3(0, UnityEngine.Random.Range(1, 5), 0);
                groundObjectsPool.Add(tileGameObject);
            }
        }
    }

    private void initEnvironment()
    {
        groundObjectsPool = new List<GameObject>();

        for (int i = 0; i < 5; i++)
        {
            Vector3 newPosition = new Vector3();
            GameObject gameObject;

            if (groundObjectsPool.Count > 0)
            {
                newPosition = groundObjectsPool[groundObjectsPool.Count - 1].transform.position + new Vector3(0, 0, groundObjectsPool[groundObjectsPool.Count - 1].GetComponent<Renderer>().bounds.size.z);
                gameObject = Instantiate((GameObject)Resources.Load(currentLevel.GroundPathCollection()[i]), newPosition, Quaternion.LookRotation(Vector3.forward));
            }
            else
            {
                Debug.Log(currentLevel.GroundPathCollection()[i]);
                gameObject = Instantiate((GameObject)Resources.Load(currentLevel.GroundPathCollection()[i]), newPosition, Quaternion.LookRotation(Vector3.forward));
            }

            gameObject.transform.localScale += new Vector3(0, UnityEngine.Random.Range(1, 5), 0);
            groundObjectsPool.Add(gameObject);
        }
    }

    private void initPlayer()
    {
        playerObject = Instantiate((GameObject)Resources.Load("Prefabs/Player/PlayerCar"));
        playerObject.transform.position = new Vector3();
    }
}
