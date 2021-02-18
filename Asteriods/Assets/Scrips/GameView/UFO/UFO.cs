using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    public GameObject spawnUFO;
    private Timer timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = FindObjectOfType<Timer>();
        for (int counter = 7; timer.timeSec > counter; counter = counter + 7)
        {
            Instantiate(spawnUFO, transform.position, transform.rotation);

        }
    }

    
}
