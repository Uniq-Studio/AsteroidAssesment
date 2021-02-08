using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //One the character is past 10 in the x coordinate and will update the location to be the opposite
        //Same idea with Y and negative
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
        if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
        if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, -6, 0);
        }
        if (transform.position.y < -6)
        {
            transform.position = new Vector3(transform.position.x, 6, 0);
        }

        //This can be used on the Asteroids and Ship and Saucers
    }

}
#region Resources
//RESOURCES USED: Help from student
//TITLE: UNKNOWN
//URL: UNKNOWN
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

