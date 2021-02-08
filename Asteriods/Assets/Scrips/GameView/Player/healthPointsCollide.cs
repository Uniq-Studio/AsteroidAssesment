using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class healthPointsCollide : MonoBehaviour
{
    #region Variables

    #region Health
    //Set Player health to 3
    public int health = 3;
    public Text textView;

    #endregion

    #region Points
    #endregion

    #region Collide
    #endregion

    #endregion


    // Update is called once per frame
    void Update()
    {
        #region Health

        textView.text = health.ToString() + " Ships left";

        #region No Health, game over
        //When Player runs out of health, Game over is displayed
        if (health == 0)
        {
            //Scene 3 is the game over screen
            SceneManager.LoadScene(3);
        }
        #endregion

        #endregion

        #region Points
        #endregion

        #region Collide
        #endregion
    }

    #region Health
    #endregion

    #region Points
    #endregion

    #region Collide

    #region Collision Detect
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        //Checks if this collied with the id
        if (collider2D.CompareTag("LargeAsteroid") || collider2D.CompareTag("MediumAsteroid") || collider2D.CompareTag("SmallAsteroid"))
        {
            //The ship goes back at 0,0
            transform.position = new Vector3(0, 0, 0);
            //Player Loses health
            health--;
        }
    }
    #endregion

    #endregion

}
#region Resources
//RESOURCES USED: Unity Forum
//TITLE: Moving an object back and forth on a single axis automatically
//URL: https://forum.unity.com/threads/moving-an-object-back-and-forth-on-a-single-axis-automatically.235033/
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
