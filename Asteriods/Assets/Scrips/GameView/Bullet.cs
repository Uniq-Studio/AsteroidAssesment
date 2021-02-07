using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region Variables
    
    //TODO (1): Create Variables to hold speed and time till despawn
    public int speed = 50;
    public float despawnTime = 10f;
    //TODO (2): Create a Variable to hold the bullet Prefab
    public Rigidbody2D rigidbody2D;
    #endregion

    #region Start
    void Start()
    {
        //TODO (3): Move the bullet up of the up and at speed
        rigidbody2D.velocity = transform.up * speed;
    }
    #endregion

    #region Update
    void Update()
    {
        //TODO (4): Despawn after a while
        despawnTime -= Time.deltaTime;
        if (despawnTime <= 0f)
        {
            //TODO (5): Despawn Bullet
            Destroy(gameObject);
        }
    }
    #endregion
}

#region Resources
//RESOURCES USED: YouTube: Brackeys
//TITLE: 2D Shooting in Unity (Tutorial)
//URL: https://www.youtube.com/watch?v=wkKsl1Mfp5M
#endregion

#region Code Details
/*
 * CODE CREATED: 	Aaron Hamilton – 06/02/2021
 * COMMENTED:		Aaron Hamilton – 06/02/2021
 * COMPLETION:		Aaron Hamilton – 06/02/2021
 * DEBUGED ON:		Aaron Hamilton – 06/02/2021
 * SPELLING CHECK:	Aaron Hamilton – 06/02/2021
 **/
#endregion

