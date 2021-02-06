using UnityEngine;
//TODO (1): Add using Scene Manager
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    //THE SCRIPT WILL ALSO BE USED IN HELP SCREEN
    //TODO (2): Create public voids for each button

    //Play Button, onClick Go to the Game Scene
    public void PlayButton()
    {
        //Game is Scene 2
        SceneManager.LoadScene(2);
    }

    //Help Button onClick Go to the Help Scene
    public void HelpButton()
    {
        //Help is Scene 1
        SceneManager.LoadScene(1);
    }

    //Quit Button onClick Quit Game
    public void QuitButton()
    {
        Application.Quit();
    }

    //Only used in help screen - Takes back to main menu
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

#region Resources
//RESOURCES USED: Class Notes - F869 34 3D Level Editing Notebook - Content Library - Platformer
//TITLE: 14 Menu
//URL: NONE
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