using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIn : MonoBehaviour
{
    public GameObject small;
    public GameObject medium;
    public GameObject large;
    public GameObject UFO;

    public int timeCount = 10;
    public int tick;

    bool UFOAlive = false;
    // Start is called before the first frame update
    void Start()
    {
        //Starts the 
        StageStart();
    }

    void Update()
    {
        //30 Seconds: Stage One
        if (tick <= 30)
        {
            while (timeCount == tick)
            {
                timeCount += Random.Range(1, 5);
                StageOne();
            }
        }
        // Between 30 seconds and 1 Minute: Stage Two
        if (tick >= 30 && tick <= 60)
        {
            while (timeCount == tick)
            {
                timeCount += Random.Range(1, 5);
                StageTwo();
            }
        }
        //Between 1 Minute and 1 minute 30 seconds: Stage Three
        if (tick >= 60 && tick <= 90)
        {
            
            while (timeCount == tick)
            {
                timeCount += Random.Range(6, 8);
                StageThree();
            }
        }
        //After 1 minute UFO now spawns in
        if( tick > 60)
        {
            if (UFOAlive == false)
            {
                AsteroidSpawn(UFO);
                UFOAlive = true;
            }
        }

        //Between 1:30 and 2:00: Stage Four
        if (tick >= 90 && tick <= 120)
        {

            while (timeCount == tick)
            {
                timeCount += Random.Range(6, 8);
                StageFour();
            }
        }

        //Between 2:00 to 3:00: Stage Five
        if (tick >= 120 && tick <= 180)
        {

            while (timeCount == tick)
            {
                timeCount += Random.Range(6, 8);
                StageFive();
            }
        }//After 3:00: Final stage from now till death

        if (tick >= 180)
        {

            while (timeCount == tick)
            {
                timeCount += Random.Range(15, 20);
                StageFinal();
            }
        }


    }


    void AsteroidSpawn(GameObject asteroid)
    {
        //Randomly Select the Locatiom
        switch (Random.Range(1, 4))
        {
            case 1:
                //TOP OF SCREEN SPAWN IN
                transform.position = transform.position + new Vector3(Random.Range(-9, 9), 5, 0);
                Instantiate(asteroid, transform.position, transform.rotation);
                transform.position = transform.position = new Vector3(0, 0, 0);
                return;

            case 2:
                //BOTTOM OF SCREEN SPAWN IN
                transform.position = transform.position + new Vector3(Random.Range(-9, 9), -5, 0);
                Instantiate(asteroid, transform.position, transform.rotation);
                transform.position = transform.position = new Vector3(0, 0, 0);
                return;

            case 3:
                //LEFT OF SCREEN SPAWN IN
                transform.position = transform.position + new Vector3(-9, Random.Range(-5, 5), 0);
                Instantiate(asteroid, transform.position, transform.rotation);
                transform.position = transform.position = new Vector3(0, 0, 0);
                return;

            case 4:
                //RIGHT OF SCREEN SPAWN IN
                transform.position = transform.position + new Vector3(9, Random.Range(-5, 5), 0);
                Instantiate(asteroid, transform.position, transform.rotation);
                transform.position = transform.position = new Vector3(0, 0, 0);
                return;
        }

    }

    public void StageStart()
    {
        //Spawns in 10 Small Asteroid
        for (int i = 0; i < 10; i++)
        {
            AsteroidSpawn(small);
        }
    }

    public void StageOne()
    {
        //Spawns in 3 Small Asteroids
        for (int i = 0; i < 3; i++)
        {
            AsteroidSpawn(small);
        }
    }

    public void StageTwo()
    {
        //Spawns in 3 Small Asteroids 1 Medium Asteroids
        for (int i = 0; i < 3; i++)
        {
            AsteroidSpawn(small);
        }

        AsteroidSpawn(medium);
    }

    public void StageThree()
    {
        //Spawns in 2 Small Asteroids 2 Medium Asteroids
        for (int i = 0; i < 2; i++)
        {
            AsteroidSpawn(small);
        }

        for (int i = 0; i < 2; i++)
        {
            AsteroidSpawn(medium);
        }
    }

    public void StageFour()
    {
        //Spawns in 1 Small Asteroid 4 Medium Asteroids 1 Large Asteroid
        AsteroidSpawn(small);

        for (int i = 0; i < 4; i++)
        {
            AsteroidSpawn(medium);
        }

        AsteroidSpawn(large);
    }

    public void StageFive()
    {
        //Spawns in 2 Small Asteroids 2 Medium Asteroids 3 Large Asteroid
        for (int i = 0; i < 2; i++)
        {
            AsteroidSpawn(small);
        }

        for (int i = 0; i < 2; i++)
        {
            AsteroidSpawn(medium);
        }

        for (int i = 0; i < 3; i++)
        {
            AsteroidSpawn(large);
        }
    }

    public void StageFinal()
    {
        //Spawns in 5 Small Asteroids 5 Medium Asteroids 5 Large Asteroids
        for (int i = 0; i < 5; i++)
        {
            AsteroidSpawn(small);
            AsteroidSpawn(medium);
            AsteroidSpawn(large);
        }
    }

    public void TickAdder()
    {
        tick++;
    }
    public void UFODead()
    {
        UFOAlive = false;
    }
}


