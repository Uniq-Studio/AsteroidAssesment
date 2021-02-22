using UnityEngine;

public class ForMedium : MonoBehaviour
{
    //TODO (3): Specify damage and points
    public int damage = 15;
    public int points = 10;
    // Start is called before the first frame update
    public GameObject small;

    int speed = 50;
    int rotation = 50;

    public Rigidbody2D rb2d;

    private Points pointsScript;

    void Start()
    {
        // Random amount of speed and roation
        rb2d.AddForce(new Vector2(Random.Range(-speed, speed), Random.Range(-speed, speed)));
        rb2d.AddTorque(Random.Range(-rotation, rotation));
        pointsScript = FindObjectOfType<Points>();
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
            for (int counter = 0; counter < 4; counter++)
            {
                Instantiate(small, transform.position, transform.rotation);
            }
            pointsScript.AddPoint(points);
        }
        //TODO (2): Create the same but with player and call meathod of damage through player script
        if (collider2D.CompareTag("Player"))
        {
            collider2D.GetComponent<Health>().AsteroidDamage(damage);
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
