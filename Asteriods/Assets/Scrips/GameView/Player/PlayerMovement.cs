using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    //TODO (1): Create a float for the move speed and public Rigidbody2D
    
     /* We want to set the speed to 5 which is a good speed to move the ship.
     * Rigidbody2D helps us Move the ship and rotate it.
     **/
    float moveSpeed = 5f;
    public Rigidbody2D rigidbod;
    #endregion

    void Update()
    {
        #region Movement
        /*
         * We will be looking at the players input W, A, S, D or even controller input and giving it the speed
         **/
        //TODO (2): Detect horizontal and times by speed
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        //TODO (3): Detect Vertical and times by speed
        float y = Input.GetAxis("Vertical") * moveSpeed;

        /*
         * This tells unity it should be affecting a Rigidbody2D that we will link through the inspector AKA the ship
         **/
        //TODO (4): Adding to rigidbody
        rigidbod.velocity = new Vector3(x, y);
        #endregion

        #region Rotation
        //TODO (5): Use “,” and “.” to rotate the Rigidbody2D
        if (Input.GetKey(","))
        {
            //We are rotating it Anti-Clockwise
            rigidbod.rotation += 2.5f;
        }
        if (Input.GetKey("."))
        {
            //We are rotating it Clockwise
            rigidbod.rotation -= 2.5f;
        }
        #endregion

    }
}

#region Resources
//RESOURCES USED: Class Notes - F869 34 3D Level Editing Notebook - Content Library - Platformer
//TITLE: 04 Player Movement
//URL: NONE

//RESOURCES USED: Unity Documentation
//TITLE: Rigidbody2D.rotation
//URL: https://docs.unity3d.com/ScriptReference/Rigidbody2D-rotation.html
#endregion

#region Code Details
/*
 * CODE CREATED: 	Aaron Hamilton – 26/01/2021
 * COMMENTED:		Aaron Hamilton – 27/01/2021
 * COMPLETION:		Aaron Hamilton – 27/01/2021
 * DEBUGED ON:		Aaron Hamilton – 26/01/2021
 * SPELLING CHECK:	Aaron Hamilton – 27/01/2021
 **/
#endregion