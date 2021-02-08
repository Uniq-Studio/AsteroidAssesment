using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForMedium : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Collision Detect
    //TODO (1): Import Collision Detection
    //Check if bullet collided
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        //Checks if this collied with the id
        if (collider2D.CompareTag("Bullet"))
        {
            //This will get removed from game space
            Destroy(gameObject);
        }
    }
    #endregion

}
#region Resources
//RESOURCES USED: 
//TITLE: 
//URL: 
#endregion

#region Code Details
/*
 * CODE CREATED: 	Aaron Hamilton – 07/02/2021
 * COMMENTED:		Aaron Hamilton – 07/02/2021
 * COMPLETION:		Aaron Hamilton – 07/02/2021
 * DEBUGED ON:		Aaron Hamilton – 07/02/2021
 * SPELLING CHECK:	Aaron Hamilton – 07/02/2021
 **/
#endregion
