using UnityEngine;
//TODO (1): Import Unity Engine IU
using UnityEngine.UI;
//TODO (DEBUG): Import SceneManager
//using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    #region Variables
    //TODO (2) Create Variables for Update time, Different part of time and Text View

    /* Create an int to hold 1 second to help with how long to run a condition */
    private int nextUpdate = 1;

    /*Created Variable to hold the seconds, minutes and Hours */
    public int timeSec = 0;
    public int timeMin = 0;
    public int timeHour = 0;

    /* Created a text view to help link the textbox and update the contents */
    public Text textView;

    SpawnIn tick;
    #endregion

    private void Start()
    {
        tick = FindObjectOfType<SpawnIn>();
    }
    // Update is called once per frame
    void Update()
    {
        #region Run Method Every Second
        //TODO (10): Check if it has been a second
        if (Time.time >= nextUpdate)
        {
            //TODO (11): Increase next update by one and call update method without arguments
            /* the next update goes up by one so when time his 2 the update =2 and will rerun the code */
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            UpdatePerSecond();
        }
        #endregion
    }

    //TODO (3): Create a method called UpdatePerSecond holding no arguments
    void UpdatePerSecond()
    {
        #region Change 60 seconds to a minute     
        //TODO (4): Check if seconds his 60
        if (timeSec > 59)
        {
            //TODO (5): Reset seconds to Zero and add one to minutes
            timeSec = 0;
            timeMin++;
        }
        #endregion

        #region Change 60 seconds to a minute 
        //TODO (6): Check if minutes hits 60
        if (timeMin > 59)
        {
            //TODO (7): Reset Minutes to Zero and add one to hours
            timeMin = 0;
            timeHour++;
        }
        #endregion

        //TODO (8): Display the current time in the Text View
        textView.text = timeHour.ToString() + (" Hours ") + timeMin.ToString() + (" Minuts ") + timeSec.ToString() + (" Seconds");

        //TODO (9): Add one to the seconds
        timeSec++;
        tick.TickAdder();

        //TODO (DEBUG): After 12 sec end game
        //if(timeSec > 12)
        //{
        //    SceneManager.LoadScene(3);
        //}
    }
}


#region Resources
//RESOURCES USED: Unity Answers
//TITLE: Inputting a variable into UI Text
//URL: https://answers.unity.com/questions/861478/inputting-a-variable-into-ui-text.html

//RESOURCES USED: Unity Answers
//TITLE: how to run update every second
//URL: https://answers.unity.com/questions/122349/how-to-run-update-every-second.html
#endregion

#region Code Details
/*
 * CODE CREATED: 	Aaron Hamilton – 31/01/2021
 * COMMENTED:		Aaron Hamilton – 01/02/2021
 * COMPLETION:		Aaron Hamilton – 01/02/2021
 * DEBUGED ON:		Aaron Hamilton – 01/02/2021
 * SPELLING CHECK:	Aaron Hamilton – 01/02/2021
 **/
#endregion

