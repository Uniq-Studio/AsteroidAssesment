using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    #region Variable
    //TODO (1): Create a GameObject for Bullet Prefab 
    //Linking the bullet Prefab
    public GameObject bulletGamePrefab;
    public Transform BulletTransform;
    #endregion

    #region Update
    void Update()
    {
        //TODO (2): Check if you hit space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //TODO (3):Spawn Bullet at the location of the ship and roation
            Instantiate(bulletGamePrefab, BulletTransform.position, BulletTransform.rotation);
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