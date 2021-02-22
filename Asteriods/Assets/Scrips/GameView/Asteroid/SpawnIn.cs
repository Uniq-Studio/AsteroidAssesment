using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIn : MonoBehaviour
{

    
    public GameObject small;
    public GameObject medium;
    public GameObject large;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        for (int i = 0; i > 5; i++)
        {
            SmallAsteroidSpawn();
        }
    }

    private void SmallAsteroidSpawn()
    {
        transform.position = transform.position + new Vector3(Random.Range(-9, 9), 5, 0);
        Instantiate(small, transform.position, transform.rotation);
    }
}
