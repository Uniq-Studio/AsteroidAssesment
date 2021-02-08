using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //TODO (1): Create Health set to 100 and TextView
    public int health = 100;
    public Text textView;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO (2): Display the current health on screen
        textView.text = health.ToString() + "% Structural Integrity ";

        #region No Health, game over
        //TODO (3): Load game over screen
        //When Player runs out of health, Game over is displayed
        if (health == 0)
        {
            //Scene 3 is the game over screen
            SceneManager.LoadScene(3);
        }
        #endregion
    }

    //TODO (3): Create a meathod to take damage for and make public
    /*each asteroid will take it own amount of damage which it willl pass through**/
    public void AsteroidDamage(int damage)
    {
        //The ship goes back at 0,0
        transform.position = new Vector3(0, 0, 0);
        //Ship loses diffrent amount of health from scrips
        health -= damage;
    }
}
#region Resources
//RESOURCES USED: Unity Forum
//TITLE: Moving an object back and forth on a single axis automatically
//URL: https://forum.unity.com/threads/moving-an-object-back-and-forth-on-a-single-axis-automatically.235033/
#endregion

#region Code Details
/*
 * CODE CREATED: 	Aaron Hamilton – 08/02/2021
 * COMMENTED:		Aaron Hamilton – 08/02/2021
 * COMPLETION:		Aaron Hamilton – 08/02/2021
 * DEBUGED ON:		Aaron Hamilton – 08/02/2021
 * SPELLING CHECK:	Aaron Hamilton – 08/02/2021
 **/
#endregion